using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

/// <summary>
/// V 1.0.0 - 2019-10-28 17:53:49
/// 首次创建
/// </summary>
namespace Util.XamariN.Converters
{
    public class BooleanConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();

            bool r = false;

            if (bool.TryParse(valueStr, out r) == false)
            {
                System.Diagnostics.Debug.WriteLine($"字符串转换布尔值发生错误\r\n字符串值: {valueStr}");
#if DEBUG
                System.Diagnostics.Debugger.Break();
#endif
            }

            return r;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "False";
            }

            if (value is bool == false)
            {
                return "False";
            }
            else
            {
                bool.TryParse(value.ToString(), out bool args);
                return args ? "True" : "False";
            }
        }
    }
}
