using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public class DateTimeUtils
    {

        // Timestamp 时间戳是指格林威治时间1970年01月01日00时00分00秒(北京时间1970年01月01日08时00分00秒)起至现在的总秒数。

        // Unix时间戳(Unix timestamp)，或称Unix时间(Unix time)、POSIX时间(POSIX time)，是一种时间表示方式，
        // 定义为从格林威治时间1970年01月01日00时00分00秒(北京时间1970年01月01日08时00分00秒)起至现在的总秒数。
        // Unix时间戳不仅被使用在Unix系统、类Unix系统中(比如Linux系统)，也在许多其他操作系统中被广泛采用。

        #region Timestamp 

        private static readonly System.DateTime Timestamp_MinValue = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));

        /// <summary>
        /// DateTime 转为 时间戳
        /// </summary>
        /// <param name="datetime"> DateTime时间格式</param>
        /// <returns>Timestamp</returns>
        public static string DateTime2Timestamp(System.DateTime datetime)
        {
            DateTime toMinus_Datetime = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second); // 去掉毫秒部分
            return (toMinus_Datetime - Timestamp_MinValue).TotalSeconds.ToString();
        }

        /// <summary>
        /// 时间戳 转为 DateTime
        /// </summary>
        /// <param name="timeStamp">Unix时间戳格式</param>
        /// <returns>DateTime</returns>
        public static DateTime Timestamp2DateTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        #endregion

    }
}
