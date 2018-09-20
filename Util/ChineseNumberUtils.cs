using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class ChineseNumberUtils
    {
        public static string ToChineseNumber(decimal args, bool isUpper = false)
        {
            string r = string.Empty;

            string tmp = args.ToString();
            for (int index = 0; index < tmp.Length; index++)
            {
                char info1 = zhongwen(tmp[index], isUpper);
                string info2 = weishu(tmp.Length - 1 - index);

                if (info1.Equals('一') && (info2.Equals("十") || info2.Equals("十万") || info2.Equals("十亿")))
                {
                    r = "{0}{1}".FormatWith(r, info2);
                    continue;
                }

                if (info1.Equals('零') && index > 0)
                {
                    continue;
                }

                r = "{0}{1}{2}".FormatWith(r, info1, info2);
            }

            return r;
        }

        private static char zhongwen(char c, bool isUpper)
        {
            char r = '零';

            if (isUpper)
            {
                switch (c)
                {
                    case '0': r = '零'; break;
                    case '1': r = '壹'; break;
                    case '2': r = '贰'; break;
                    case '3': r = '叁'; break;
                    case '4': r = '肆'; break;
                    case '5': r = '伍'; break;
                    case '6': r = '陆'; break;
                    case '7': r = '柒'; break;
                    case '8': r = '捌'; break;
                    case '9': r = '玖'; break;
                }
            }
            else
            {
                switch (c)
                {
                    case '0': r = '零'; break;
                    case '1': r = '一'; break;
                    case '2': r = '二'; break;
                    case '3': r = '三'; break;
                    case '4': r = '四'; break;
                    case '5': r = '五'; break;
                    case '6': r = '六'; break;
                    case '7': r = '七'; break;
                    case '8': r = '八'; break;
                    case '9': r = '九'; break;
                }
            }

            return r;
        }

        private static string weishu(int index)
        {
            string r = string.Empty;
            switch (index)
            {
                case 1: r = "十"; break;
                case 2: r = "百"; break;
                case 3: r = "千"; break;

                case 4: r = "万"; break;
                case 5: r = "十"; break; // 十万
                case 6: r = "百"; break;
                case 7: r = "千"; break;

                case 8: r = "亿"; break;
                case 9: r = "十"; break; // 十亿
                case 10: r = "百"; break;
                case 11: r = "千"; break;

                case 12: r = "兆"; break;
            }

            return r;
        }
    }
}
