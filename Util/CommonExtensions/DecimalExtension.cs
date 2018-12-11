using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class DecimalExtension
    {
        /// <summary>
        /// 去除后面的 0 
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static decimal TrimZero(this decimal arg)
        {
            string s = arg.ToString();

            char[] charArray = s.ToCharArray();

            string fixString = string.Empty;

            bool continueZero = true;

            if (charArray.ToList().Contains('.')) // 不含小数点的不需要进行去零
            {
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    if (continueZero == true && charArray[i] == '0')
                    {
                        continueZero = true;
                        continue;
                    }

                    continueZero = false;
                    fixString = "{0}{1}".FormatWith(charArray[i], fixString);
                }
            }
            else
            {
                fixString = s;
            }

            decimal r = 0M;

            if (decimal.TryParse(fixString, out r) == false)
            {
                if (arg == 0M)
                {
                    return 0M;
                }
                else
                {
                    throw new Exception("转换decimal失败");
                }
            }

            if (arg.CompareTo(r) != 0)
            {
                string msg = "TrimZero 转换后值不相等请进行排查。\r\nargs:{0}\r\nr:{1}".FormatWith(arg, r);
                throw new Exception(msg);
            }

            return r;
        }
    }
}
