using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Excel
{

    /// <summary>
    /// 转换器Model
    /// Excel Column 转换 实体类
    /// </summary>
    public class PropertyColumn
    {
        public PropertyColumn()
        {
            this.ColumnIndex = -1;
        }

        public string PropertyName
        {
            get;
            set;
        }

        public string ExcelColumn
        {
            get;
            set;
        }

        public int ColumnIndex
        {
            get;
            set;
        }

        /// <summary>
        /// Excel中 列对应的单元格名称
        /// 
        /// 例如 
        /// 0 - A
        /// 23 - Z
        /// 24 - AA
        /// </summary>
        public string ColumnIndexName { get; set; }
    }

    /// <summary>
    /// 读取Excel工作表请继承此类
    /// 
    /// 注意 : 对于所有时间类型(日期\时间\日期时间) 请使用 DateTime
    /// </summary>
    public class ExcelModel
    {
        /// <summary>
        /// Excel文件所在行号
        /// </summary>
        public int ExcelRowNumber { get; set; }

        public string ExcelRowErrorInfo { get; set; }
    }

}
