using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// V 1.0.2 - 2019-9-23 11:11:46
    /// (1) 增加表明转换参数
    /// (2) 优化转换逻辑 : 分析到属性为集合属性, 将其转换成 Json 字符串
    /// 
    /// V 1.0.1 - 2018-3-19 09:51:18
    /// 忽略属性列表
    /// </summary>
    public static class LinqToDataTable
    {
        /// <summary>
        /// 集合转换为DataTable
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="list">待转换的集合</param>
        /// <param name="transferDict">设置需要为输出的属性名转换名称的字典, 默认null</param>
        /// <param name="ignorePropertyTypeNameList">设置不需要输出的属性名集合, 默认null</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> list, Dictionary<string, string> transferDict = null, List<string> ignorePropertyTypeNameList = null)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] propArray = null;

            foreach (T rec in list)
            {
                #region 定义DataTalbe

                if (propArray == null)
                {
                    propArray = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in propArray)
                    {
                        #region 跳过不需要转换的属性

                        if (ignorePropertyTypeNameList != null && ignorePropertyTypeNameList.Exists(p => p.Equals(pi.Name)))
                        {
                            continue;
                        }

                        #endregion

                        Type colType = pi.PropertyType;
                        if (colType.IsGenericType == true)
                        {
                            if (colType.GetGenericTypeDefinition() == typeof(Nullable<>))
                            {
                                // 如果是泛型 并且 是Nullable<T> -- 这样处理的原因 DataTable (正式报错提示DataSet) 不支持Nullable<> 类型
                                colType = colType.GetGenericArguments()[0];
                            }
                            else
                            {
                                // 如果是集合则转换为 json 字符串
                                colType = typeof(string);
                            }
                        }

                        // 转换 ColumnName 字典中含有对应列名
                        string columnName = pi.Name;
                        if (transferDict != null && transferDict.TryGetValue(pi.Name, out string tmp))
                        {
                            columnName = tmp;
                        }

                        dt.Columns.Add(new DataColumn(columnName, colType));
                    }
                }

                #endregion

                #region 赋值

                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);

                foreach (PropertyInfo pi in propArray)
                {
                    #region 跳过不需要转换的属性

                    if (ignorePropertyTypeNameList != null && ignorePropertyTypeNameList.Exists(p => p.Equals(pi.Name)))
                    {
                        continue;
                    }

                    #endregion

                    // 转换 ColumnName 字典中含有对应列名
                    string columnName = pi.Name;
                    if (transferDict != null && transferDict.TryGetValue(pi.Name, out string tmp))
                    {
                        columnName = tmp;
                    }

                    if (pi.PropertyType.IsGenericType == true
                        && pi.PropertyType.GetGenericTypeDefinition() != typeof(Nullable<>)
                        && pi.GetValue(rec, null) != null
                    )
                    {
                        dr[columnName] = Util.JsonUtils.SerializeObject(pi.GetValue(rec, null));
                        continue;
                    }

                    dr[columnName] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);
                }

                #endregion
            }

            return dt;
        }

        /// <summary>
        /// 集合转换为DataTable
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="list">待转换的集合</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            return LinqToDataTable.ToDataTable(list, null, null);
        }
    }
}
