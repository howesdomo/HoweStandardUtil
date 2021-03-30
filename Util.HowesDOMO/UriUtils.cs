using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// Uri 工具类
    /// 
    /// V 1.0.0 - 2021-03-30 16:25:56
    /// 实现 Combine 方法
    /// </summary>
    public class UriUtils
    {
        public readonly static char[] SlashCharArr = new char[] { '/', '\\' };

        public static Uri Combine(Uri uri, string path)
        {
            if (uri == null)
            {
                throw new ArgumentNullException("Uri为空值");
            }

            string a1 = uri.ToString().TrimEnd(SlashCharArr);

            string b1 = path.TrimStart(SlashCharArr);

            string combine = $"{a1}/{b1}";
            Uri r = new Uri(combine);

            if (Uri.IsWellFormedUriString(r.ToString(), UriKind.RelativeOrAbsolute) == false)
            {                
                throw new ArgumentException($"组合后Uri验证失败。\r\n组合后：{combine}\r\na1：{a1}\r\nb1：{b1}");
            }

            return r;
        }
    }
}
