using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// V 1 - 2021-01-25 17:13:00
    /// 常用正则表达式收集
    /// </summary>
    public class RegexUtils
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public static string IPAddress = @"^(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])$";


        /// <summary>
        /// 端口
        /// </summary>
        public static string Port = @"^([0-9]|[1-9]\d{1,3}|[1-5]\d{4}|6[0-4]\d{3}|65[0-4]\d{2}|655[0-2]\d|6553[0-5])$";
    }
}
