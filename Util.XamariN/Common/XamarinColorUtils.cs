using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN.Common
{
    public class XamarinColorUtils
    {
        #region Color 2 String

        public static string Color2HexString(Xamarin.Forms.Color c)
        {
            return XamarinColorUtils.GetHexString(c.R, c.G, c.B);
        }

        public static string GetHexString(double a_r, double a_g, double a_b)
        {
            int r, g, b = 0;

            r = Convert.ToInt32(a_r * 255d);
            g = Convert.ToInt32(a_g * 255d);
            b = Convert.ToInt32(a_b * 255d);

            string result = string.Format("#{0}{1}{2}",
                    r.ToString("X").PadLeft(2, '0'),
                    g.ToString("X").PadLeft(2, '0'),
                    b.ToString("X").PadLeft(2, '0'));

            return result;
        }

        public static string Color2HexWithAlphaString(Xamarin.Forms.Color c)
        {
            return XamarinColorUtils.GetHexWithAlphaString(c.R, c.G, c.B, c.A);
        }

        public static string GetHexWithAlphaString(double a_r, double a_g, double a_b, double a_a)
        {
            int r, g, b, a = 0;

            r = Convert.ToInt32(a_r * 255d);
            g = Convert.ToInt32(a_g * 255d);
            b = Convert.ToInt32(a_b * 255d);
            a = Convert.ToInt32(a_a * 255d);

            string result = string.Format
            (
                "#{0}{1}{2}{3}",
                    r.ToString("X").PadLeft(2, '0'),
                    g.ToString("X").PadLeft(2, '0'),
                    b.ToString("X").PadLeft(2, '0'),
                    a.ToString("X").PadLeft(2, '0')
            )
            ;

            return result;
        }

        #endregion

        #region String 2 Color

        private static System.Text.RegularExpressions.Regex sRegexHex = new System.Text.RegularExpressions.Regex("^#[0-9A-Fa-f]{6}$");

        private static System.Text.RegularExpressions.Regex sRegexHexWithAlpha = new System.Text.RegularExpressions.Regex("^#[0-9A-Fa-f]{8}$");

        /// <summary>
        /// 根据字符串获取颜色
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static Xamarin.Forms.Color String2Color(string args)
        {
            Xamarin.Forms.Color result = Xamarin.Forms.Color.Black;

            int intR, intG, intB = 0;
            int intA = 255;

            try
            {
                if (sRegexHex.IsMatch(args) == true)
                {
                    // 通过 Hex 获取颜色
                    string r = args.Substring(1, 2);
                    string g = args.Substring(3, 2);
                    string b = args.Substring(5, 2);

                    intR = Convert.ToInt32(r, 16);
                    intG = Convert.ToInt32(g, 16);
                    intB = Convert.ToInt32(b, 16);

                    result = Xamarin.Forms.Color.FromRgba(intR, intG, intB, 255);
                }
                else if (sRegexHexWithAlpha.IsMatch(args) == true)
                {
                    // 通过 Hex With Alpha 获取颜色
                    string r = args.Substring(1, 2);
                    string g = args.Substring(3, 2);
                    string b = args.Substring(5, 2);
                    string a = args.Substring(7, 2);

                    intR = Convert.ToInt32(r, 16);
                    intG = Convert.ToInt32(g, 16);
                    intB = Convert.ToInt32(b, 16);
                    intA = Convert.ToInt32(a, 16);

                    result = Xamarin.Forms.Color.FromRgba(intR, intG, intB, intA);
                }
                else
                {
                    // 通过颜色名称获取颜色
                    System.Reflection.FieldInfo fieldInfo = typeof(Xamarin.Forms.Color).GetField(args);
                    if (fieldInfo != null)
                    {
                        result = (Xamarin.Forms.Color)fieldInfo.GetValue(null);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine($"{args} not found in Xamarin.Forms.Color");
#if DEBUG
                        System.Diagnostics.Debugger.Break();
#endif
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.GetFullInfo());
#if DEBUG
                System.Diagnostics.Debugger.Break();
#endif

                result = Xamarin.Forms.Color.Black;
            }

            return result;
        }

        #endregion
    }
}
