using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class TimeSpanExtension
    {
        /// <summary>
        /// 去掉换行符号后 Trim
        /// </summary>
        /// <param name="content"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string ToStringAdv(this TimeSpan ts)
        {
            string r = string.Empty;

            if (ts.Hours > 0)
            {
                r += "{0}小时".FormatWith(ts.Hours);
            }

            if (ts.Minutes > 0)
            {
                r += "{0}分".FormatWith(ts.Minutes);
            }

            if (ts.Seconds > 0)
            {
                r += "{0}秒".FormatWith(ts.Seconds);
            }

            //if (ts.Milliseconds > 0)
            //{
            //    r = "{0}毫秒".FormatWith(ts.Milliseconds);
            //}

            return r;
        }

    }
}
