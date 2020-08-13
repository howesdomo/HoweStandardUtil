using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    /// <summary>
    /// V 1.0.0 - 2020-08-13 14:02:55
    /// 首次创建
    /// </summary>
    public static class CharExtension
    {
        #region 判断 Char 是中文字符

        // 知识点 : 中文字符范围（0x4e00～0x9fff）转换成int

        /// <summary>
        /// 中文字符起始
        /// </summary>
        public const int ChineseCharacterFrom = 19968; // Convert.ToInt32("4e00", 16);

        /// <summary>
        /// 中文字符结束
        /// </summary>
        public const int ChineseCharacterTo = 40959; // Convert.ToInt32("9fff", 16);

        /// <summary>
        /// 是中文字符
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsChineseCharacter(this char c)
        {
            return ChineseCharacterFrom <= c && c <= ChineseCharacterTo;
        }

        #endregion

    }
}
