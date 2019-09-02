using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Excel
{
    public class ExcelCommonMethod
    {
        #region ExcelColumnName, Index 互转

        /// <summary>
        /// Excel 列名转 Index
        /// A -> 0
        /// AA -> 26
        /// </summary>
        /// <param name="excelColumnName">Excel 列名</param>
        /// <returns>Index</returns>
        public static int ToIndex(string excelColumnName)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(excelColumnName.ToUpper(), @"[A-Z]+"))
            {
                throw new Exception("invalid parameter");
            }
            int index = 0;
            char[] chars = excelColumnName.ToUpper().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index += ((int)chars[i] - (int)'A' + 1) * (int)Math.Pow(26, chars.Length - i - 1);
            }
            return index - 1;
        }

        /// <summary>
        /// Index 转 Excel 列名
        /// 0 -> A
        /// 26 -> AA
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Excel 列名</returns>
        public static string ToExcelColumnName(int index)
        {
            if (index < 0)
            {
                throw new Exception("invalid parameter");
            }
            List<string> chars = new List<string>();
            do
            {
                if (chars.Count > 0)
                {
                    index--;
                }
                chars.Insert(0, ((char)(index % 26 + (int)'A')).ToString());
                index = (int)((index - index % 26) / 26);
            } while (index > 0);

            return String.Join(string.Empty, chars.ToArray());
        }


        #endregion
    }
}
