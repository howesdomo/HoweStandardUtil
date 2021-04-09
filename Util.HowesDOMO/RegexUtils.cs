using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
	/// V 4 - 2021-04-09 23:36:12
	/// 弃用 IPAddress, 改用 IPV4
	///
    /// V 3 - 2021-03-01 17:19:00
    /// 修改类型为 const, 让正则表达式可以直接在 DataAnnotations 上使用
    /// 
    /// V 2 - 2021-02-01 17:11:21
    /// 增加自然数的正则表达式
    /// 
    /// V 1 - 2021-01-25 17:13:00
    /// 常用正则表达式收集
    /// </summary>
    public class RegexUtils
    {
        /// <summary>
        /// IP地址
        /// </summary>
        [Obsolete("改用IPV4")]
        public const string IPAddress = @"^(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])$";

        /// <summary>
        /// IPV4
        /// </summary>
        public const string IPV4 = @"^(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d{2}|2[0-4]\d|25[0-5])$";


        /// <summary>
        /// <para>端口</para>
        /// <para>0 - 65535</para>
        /// </summary>
        public const string Port = @"^([0-9]|[1-9]\d{1,3}|[1-5]\d{4}|6[0-4]\d{3}|65[0-4]\d{2}|655[0-2]\d|6553[0-5])$";

        /// <summary>
        /// <para>自然数</para>
        /// <para>指非负整数 ( 0, 1, 2, 3, 4, ...)，</para>
        /// <para>为免歧义有时也直接以非负整数代替自然数使用。数学中，一般以 N 代表以自然数组成的集合。自然数集是一个可数的，无上界的无穷集合。</para>
        /// </summary>
        public const string NaturalNumber = @"^[1-9](?:\d{0,2}(?:,\d{3})+|\d*)$"; 
        
    }
}
