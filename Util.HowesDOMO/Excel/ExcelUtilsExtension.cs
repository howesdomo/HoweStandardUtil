using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Excel
{
    /// <summary>
    /// ExcelUtils 扩展方法
    /// </summary>
    public static class ExcelUtilsExtension
    {
        /// <summary>
        /// 系统根据列名 (ExcelColumn) 计算 ColumnIndex
        /// </summary>
        /// <param name="list"></param>
        /// <param name="propertyName"></param>
        /// <param name="excelColumn"></param>
        /// <returns></returns>
        public static List<PropertyColumn> Add(this List<PropertyColumn> list, string propertyName, string excelColumn)
        {
            list.Add(new PropertyColumn()
            {
                PropertyName = propertyName,
                ExcelColumn = excelColumn
            });
            return list;
        }

        /// <summary>
        /// ColumnIndex 固定位置
        /// </summary>
        /// <param name="list"></param>
        /// <param name="propertyName"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public static List<PropertyColumn> Add(this List<PropertyColumn> list, string propertyName, int columnIndex)
        {
            list.Add(new PropertyColumn()
            {
                PropertyName = propertyName,
                ColumnIndex = columnIndex
            });
            return list;
        }
    }
}
