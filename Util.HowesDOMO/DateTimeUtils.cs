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

        private static readonly System.DateTime Timestamp_MinValue = new System.DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// DateTime 转为 时间戳
        /// </summary>
        /// <param name="datetime"> DateTime时间格式</param>
        /// <returns>Timestamp</returns>
        public static string DateTime2Timestamp(System.DateTime datetime)
        {
            // 处理传入的Datetime
            // 1 去掉毫秒
            // 2 转为UTC
            DateTime toMinus_Datetime = new DateTime(datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Kind)
                                        .ToUniversalTime();

            return (toMinus_Datetime - Timestamp_MinValue).TotalSeconds.ToString();
        }

        /// <summary>
        /// 时间戳 转为 DateTime
        /// </summary>
        /// <param name="timeStamp">Unix时间戳格式</param>
        /// <returns>DateTime</returns>
        public static DateTime Timestamp2DateTime_UTC(string timeStamp)
        {
            DateTime dtStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        /// <summary>
        /// 时间戳 转为 DateTime
        /// </summary>
        /// <param name="timeStamp">Unix时间戳格式</param>
        /// <returns>DateTime</returns>
        public static DateTime Timestamp2DateTime_Local(string timeStamp)
        {
            DateTime dtStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow).ToLocalTime();
        }

        #endregion

    }
}
