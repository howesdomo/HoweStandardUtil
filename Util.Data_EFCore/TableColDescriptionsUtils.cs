using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Util.Data_EFCore
{
    /// <summary>
    /// 将 Model 的说明属性更新到数据库的表说明与字段说明中
    ///
    /// V 1.0.0 - 2021-03-16 11:29:19
    /// 首次从 SecuritySolution 整理到 Util.Data_EFCore 中
    /// </summary>
    public class TableColDescriptionsUtils
    {
        public void UpdateTableColDescriptions(DbContext context)
        {
            var dbProps = context.GetDbSetProperties();
            foreach (PropertyInfo prop in dbProps)
            {
                #region Get DAO type

                //Get DbSet's model. For example, DbSet<MyModel> => MyModel
                Type typeArgument = prop.PropertyType.GetGenericArguments()[0];

                #endregion

                #region Get Table description

                Object tableNameAttr = this.getTableAttribute(typeArgument, "TableAttribute");
                Object descAttr = this.getTableAttribute(typeArgument, "DescriptionAttribute");

                string tableName = string.Empty;
                if (tableNameAttr == null) // 若程序员没有设置 Table 标签, 则使用默认名 ( 类名s )
                {
                    tableName = $"{prop.Name}";
                }
                else
                {
                    tableName = (tableNameAttr as System.ComponentModel.DataAnnotations.Schema.TableAttribute).Name; // 读取Table标签的值
                }

                string tableDescription = string.Empty;
                if (descAttr != null)
                {
                    tableDescription = (descAttr as System.ComponentModel.DescriptionAttribute).Description;
                }

                if (!string.IsNullOrEmpty(tableDescription))
                {
                    this.syncTableDescription(context, tableName, tableDescription);
                }

                #endregion

                #region Get Columns description

                if (!string.IsNullOrEmpty(tableName))
                {
                    List<string> cols = this.getColsFromTable(context, tableName);
                    var methodProp = typeof(AttributeUtility).GetMethod("GetPropertyAttributes");
                    foreach (string col in cols)
                    {
                        List<Object> propDescAttrs = null;
                        try
                        {
                            propDescAttrs = this.getPropAttribute(typeArgument, col, "DescriptionAttribute");
                        }
                        catch (Exception)
                        {
                            string fixCol = col.ReplaceWithRegexPattern("[Ii][Dd]$", "");
                            propDescAttrs = this.getPropAttribute(typeArgument, fixCol, "DescriptionAttribute");
                        }

                        if (propDescAttrs != null && propDescAttrs.Count > 0)
                        {
                            string columnDescription = (propDescAttrs[0] as System.ComponentModel.DescriptionAttribute).Description;
                            Debug.WriteLine($"{tableName}.{col} = {columnDescription}");

                            //Sync to database
                            this.syncColDescription(context, tableName, col, columnDescription);
                        }
                    }
                }

                #endregion            
            }
        }

        /// Get attribute of class
        private object getTableAttribute(Type typeArgument, string attribute)
        {
            var method = typeof(AttributeUtility).GetMethod("GetClassAttributes");
            var generic = method.MakeGenericMethod(typeArgument);
            var result = generic.Invoke(null, new object[] { false });
            var dics = (result as Dictionary<string, object>);

            Object value = null;
            if (dics.TryGetValue(attribute, out value))
                return value;
            else
                return null;
        }

        /// Get attribute of property
        private List<object> getPropAttribute(Type typeArgument, string propName, string attribute)
        {
            var method = typeof(AttributeUtility).GetMethod("GetPropertyAttributes");
            var generic = method.MakeGenericMethod(typeArgument);
            var result = generic.Invoke(null, new object[] { propName, false });
            var dics = (result as Dictionary<string, List<object>>);

            List<Object> values = null;
            if (dics.TryGetValue(attribute, out values))
            {
                return values;
            }
            else
            {
                return null;
            }
        }

        /// Get all Column names of a Table
        private List<string> getColsFromTable(DbContext context, string tableName)
        {
            // return context.Database.SqlQuery<string>(sql).ToList();


            List<string> r = new List<string>();
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                string sql = $@"SELECT COLUMN_NAME 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = '{tableName}' AND TABLE_SCHEMA='dbo'";

                command.CommandText = sql;
                context.Database.OpenConnection();
                using (System.Data.Common.DbDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string toAdd = Util.CommonDal.ReadString(dr["COLUMN_NAME"]);
                        r.Add(toAdd);
                    }
                }
            }

            return r;
        }


        /// <summary>
        /// 将Model的说明属性更新到数据库表的说明中
        /// Use sp_addextendedproperty/sp_updateextendedproperty to update the Description of a Table
        /// </summary>
        /// <param name="context"></param>
        /// <param name="tableName"></param>
        /// <param name="description"></param>
        private void syncTableDescription(DbContext context, string tableName, string description)
        {
            string sql = string.Empty;
            int rslt = 0;
            try
            {
                sql = $@"
    EXEC sp_updateextendedproperty   
     @name = N'MS_Description',  
     @value = '{description}',  
     @level0type = N'Schema', @level0name = dbo,  
     @level1type = N'Table',  @level1name = {tableName}";
                // rslt = context.Database.ExecuteSqlCommand(sql);
                rslt = context.Database.ExecuteSqlInterpolated(System.Runtime.CompilerServices.FormattableStringFactory.Create(sql));
            }
            catch (Exception)
            {
                sql = $@"
    EXEC sp_addextendedproperty   
     @name = N'MS_Description',  
     @value = '{description}',  
     @level0type = N'Schema', @level0name = dbo,  
     @level1type = N'Table',  @level1name = {tableName}";
                // context.Database.ExecuteSqlCommand(sql);
                rslt = context.Database.ExecuteSqlInterpolated(System.Runtime.CompilerServices.FormattableStringFactory.Create(sql));
            }

        }

        /// <summary>
        /// 将Model旗下的属性的说明更新到数据库表内的字段的说明中
        /// Use sp_addextendedproperty/sp_updateextendedproperty to update the Description of a Column
        /// </summary>
        /// <param name="context"></param>
        /// <param name="tableName"></param>
        /// <param name="colName"></param>
        /// <param name="description"></param>
        private void syncColDescription(DbContext context, string tableName, string colName, string description)
        {
            string sql = string.Empty;
            try
            {
                sql = $@"
EXEC sp_updateextendedproperty   
    @name = N'MS_Description'  
    ,@value = '{description}'  
    ,@level0type = N'Schema', @level0name = dbo  
    ,@level1type = N'Table',  @level1name = {tableName}
    ,@level2type = N'Column', @level2name = ""{colName}"";";

                // context.Database.ExecuteSqlCommand(sql);
                context.Database.ExecuteSqlInterpolated(System.Runtime.CompilerServices.FormattableStringFactory.Create(sql));
            }
            catch (Exception)
            {
                sql = $@"
EXEC sp_addextendedproperty   
    @name = N'MS_Description'  
    ,@value = '{description}'  
    ,@level0type = N'Schema', @level0name = dbo  
    ,@level1type = N'Table',  @level1name = {tableName}
    ,@level2type = N'Column', @level2name = ""{colName}""";

                // context.Database.ExecuteSqlCommand(sql);
                context.Database.ExecuteSqlInterpolated(System.Runtime.CompilerServices.FormattableStringFactory.Create(sql));
            }
        }
    }
}
