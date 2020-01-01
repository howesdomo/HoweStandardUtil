using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// V 1.0.0 - 2019-10-28 17:53:49
/// 首次创建
/// </summary>
namespace Util.XamariN.Converters
{
    public class ColorConverter: Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();
            // 不能使用在 Foreground , 请使用 BrushConvert
            return Util.XamariN.Common.XamarinColorUtils.String2Color(valueStr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value is Xamarin.Forms.Color) == false)
            {
                return string.Empty;
            }

            return Util.XamariN.Common.XamarinColorUtils.Color2HexWithAlphaString((Xamarin.Forms.Color)value);
        }
    }
}
