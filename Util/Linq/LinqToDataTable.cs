using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// V1 - 2018-3-19 09:51:18
    /// 忽略属性列表
    /// </summary>
    public static class LinqToDataTable
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list, List<string> ignorePropertyTypeNameList)
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
                        // 如果是泛型 并且 是Nullable<T> -- 这样处理的原因 DataTable (正式报错提示DataSet) 不支持Nullable<> 类型
                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }
                        dt.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                #endregion

                #region 赋值

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pi in propArray)
                {
                    #region 跳过不需要转换的属性

                    if (ignorePropertyTypeNameList != null && ignorePropertyTypeNameList.Exists(p => p.Equals(pi.Name)))
                    {
                        continue;
                    }

                    #endregion

                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);
                }

                dt.Rows.Add(dr);

                #endregion
            }

            return dt;
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            return LinqToDataTable.ToDataTable(list, null);
        }

        //public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        //{
        //    DataTable dt = new DataTable();
        //    PropertyInfo[] propArray = null;

        //    foreach (T rec in list)
        //    {
        //        #region 定义DataTalbe

        //        if (propArray == null)
        //        {
        //            propArray = ((Type)rec.GetType()).GetProperties();
        //            foreach (PropertyInfo pi in propArray)
        //            {
        //                Type colType = pi.PropertyType;
        //                // 如果是泛型 并且 是Nullable<T> -- 这样处理的原因 DataTable (正式报错提示DataSet) 不支持Nullable<> 类型
        //                if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
        //                {
        //                    colType = colType.GetGenericArguments()[0];
        //                }
        //                dt.Columns.Add(new DataColumn(pi.Name, colType));
        //            }
        //        }

        //        #endregion

        //        #region 赋值

        //        DataRow dr = dt.NewRow();

        //        foreach (PropertyInfo pi in propArray)
        //        {
        //            dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);
        //        }

        //        dt.Rows.Add(dr);

        //        #endregion
        //    }

        //    return dt;
        //}
    }
}
