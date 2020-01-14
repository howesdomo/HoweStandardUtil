using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.Converters
{
    public class FontAttributesConverter : IValueConverter
    {
        private static readonly Xamarin.Forms.FontAttributesConverter sBaseFontAttributesConverter = new Xamarin.Forms.FontAttributesConverter();

        /// <summary>
        /// 
        /// 思路
        /// 先采用Xamarin.Forms默认的转换器进行一次转换
        /// 若有异常则采用自定义的方式进行转换
        /// 若仍然不满足switch的条件 ( 1 - 3 ), 则转换为 None
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();

            FontAttributes r = FontAttributes.None;
            try
            {
                r = (FontAttributes)sBaseFontAttributesConverter.ConvertFromInvariantString(value.ToString());
            }
            catch(Exception)
            {
                switch (valueStr)
                {
                    case "1": r = FontAttributes.Bold; break;
                    case "2": r = FontAttributes.Italic; break;
                    case "3": r = FontAttributes.Bold | FontAttributes.Italic; break;
                    default:
                        string msg = $"Util.XamariN.Converters.FontAttributesConverter 转换 {valueStr} 值时不满足switch要求";
                        System.Diagnostics.Debug.WriteLine(msg);
                        break;
                }
            }
            return r;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
