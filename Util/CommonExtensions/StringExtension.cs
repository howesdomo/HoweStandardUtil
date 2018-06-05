using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    public static class StringExtension
    {
        #region 空值判断

        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        #endregion 空值判断

        #region Trim

        /// <summary>
        /// 去掉换行符号后 Trim
        /// </summary>
        /// <param name="content"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string TrimAdv(this string content, params object[] args)
        {
            if (content == null)
            {
                return null;
            }

            return content.Replace("\r", "").Replace("\n", "").Trim();
        }

        #endregion

        #region String.Format ( 格式化 )

        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }

        public static string Format(IFormatProvider provider, string format, params object[] args)
        {
            return string.Format(provider, format, args);
        }

        // *** 尽管第1个的Format功能强大到可以取代中间的三个，但它的效率不高。
        // 以下3个重载是出于性能的考虑而增加的
        public static string Format(this string format, object arg0)
        {
            return string.Format(format, arg0);
        }

        public static string Format(this string format, object arg0, object arg1)
        {
            return string.Format(format, arg0, arg1);
        }

        public static string Format(this string format, object arg0, object arg1, object arg2)
        {
            return string.Format(format, arg0, arg1, arg2);
        }

        #endregion

        #region Regex 正则表达式

        /// <summary>
        /// 判断是否符合正则表达式
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static bool IsMatch(this string s, string pattern)
        {
            if (s == null) return false;
            else return Regex.IsMatch(s, pattern);
        }

        /// <summary>
        /// 获取符合正则表达式的值
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static string Match(this string s, string pattern)
        {
            if (s == null) return "";
            return Regex.Match(s, pattern).Value;
        }

        /// <summary>
        /// 使用正则表达式进行替换字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="pattern"></param>
        /// <param name="replaceValue"></param>
        /// <returns></returns>
        public static string ReplaceWithRegexPattern(this string s, string pattern, string replaceValue)
        {
            if (s == null) return "";
            return Regex.Replace(s, pattern, replaceValue);
        }

        #endregion

        #region 常用类型转换

        public static bool IsBoolean(this string s)
        {
            bool i;
            return bool.TryParse(s, out i);
        }

        public static bool ToBoolean(this string s)
        {
            return bool.Parse(s);
        }

        public static bool IsInt(this string s)
        {
            int i;
            return int.TryParse(s, out i);
        }

        public static int ToInt(this string s)
        {
            return int.Parse(s);
        }

        public static bool IsLong(this string s)
        {
            long i;
            return long.TryParse(s, out i);
        }

        public static long ToLong(this string s)
        {
            return long.Parse(s);
        }

        public static bool IsDouble(this string s)
        {
            double i;
            return double.TryParse(s, out i);
        }

        public static double ToDouble(this string s)
        {
            return double.Parse(s);
        }

        public static bool IsDecimal(this string s)
        {
            decimal i;
            return decimal.TryParse(s, out i);
        }

        public static decimal ToDecimal(this string s)
        {
            return decimal.Parse(s);
        }

        public static bool IsDateTime(this string s)
        {
            DateTime i;
            return DateTime.TryParse(s, out i);
        }

        public static DateTime ToDateTime(this string s)
        {
            return DateTime.Parse(s);
        }

        #endregion

        #region 字符串转化 美化

        public static string ToCamel(this string s)
        {
            // 尚可进一步优化 根据英文单词 进行驼峰式命名
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToLower() + s.Substring(1);
        }

        public static string ToPascal(this string s)
        {
            // 尚可进一步优化 根据英文单词 进行Pascal命名
            if (s.IsNullOrEmpty()) return s;
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        ///// <summary>
        ///// 获取拼音
        ///// </summary>
        ///// <param name="s"></param>
        ///// <returns></returns>
        //public static string ToPinYin(this string s)
        //{
        //    string r = string.Empty;
        //    foreach (char obj in s)
        //    {
        //        try
        //        {
        //            ChineseChar chineseChar = new ChineseChar(obj);
        //            string t = chineseChar.Pinyins[0].ToString(); // 从拼音列表中获取第一个值 ( 例如 左 ==> ZUO3 )
        //            r += t.Substring(0, t.Length - 1); // 去掉音调 ( 例如 ZUO3 ==> ZUO )
        //        }
        //        catch
        //        {
        //            r += obj.ToString();
        //        }
        //    }
        //    return r;
        //}

        ///// <summary>
        ///// 获取拼音首字母
        ///// </summary>
        ///// <param name="s"></param>
        ///// <returns></returns>
        //public static string ToPinYinFirstLetter(this string s)
        //{
        //    string r = string.Empty;
        //    foreach (char obj in s)
        //    {
        //        try
        //        {
        //            ChineseChar chineseChar = new ChineseChar(obj);
        //            string t = chineseChar.Pinyins[0].ToString();  // 从拼音列表中获取第一个值 ( 例如 左 ==> ZUO3 )
        //            r += t.Substring(0, 1); // 获取拼音首字母 ( 例如 ZUO3 ==> Z )
        //        }
        //        catch
        //        {
        //            r += obj.ToString();
        //        }
        //    }
        //    return r;
        //}

        ///// <summary>
        ///// 转为繁体
        ///// </summary>
        ///// <param name="s"></param>
        ///// <returns></returns>
        //public static string ToTraditionalString(this string s)
        //{
        //    string r = string.Empty;
        //    r = ChineseConverter.Convert(s, ChineseConversionDirection.SimplifiedToTraditional);
        //    return r;
        //}

        ///// <summary>
        ///// 转为简体
        ///// </summary>
        ///// <param name="s"></param>
        ///// <returns></returns>
        //public static string ToSimplifiedString(this string s)
        //{
        //    string r = string.Empty;
        //    r = ChineseConverter.Convert(s, ChineseConversionDirection.TraditionalToSimplified);
        //    return r;
        //}

        #endregion
    }
}
