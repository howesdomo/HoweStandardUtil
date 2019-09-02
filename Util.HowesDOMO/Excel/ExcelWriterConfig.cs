using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Excel
{
    public class ExcelWriterConfig
    {
        /// <summary>
        /// 文件写入模式
        /// 0 全部重写,
        /// 1 追加
        /// </summary>
        public ExcelWriteModel WriteMode { get; set; }

        /// <summary>
        /// 重命名SheetName
        /// </summary>
        public List<string> SheetNameList { get; set; }
    }

    /// <summary>
    /// 文件写入模式
    /// </summary>
    public enum ExcelWriteModel
    {
        CreateNew = 0,
        Append = 1
    }
}
