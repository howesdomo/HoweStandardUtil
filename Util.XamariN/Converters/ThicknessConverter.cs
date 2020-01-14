using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

/// <summary>
/// V 1.0.0 - 2020-1-9 14:43:32
/// 首次创建
/// </summary>
namespace Util.XamariN.Converters
{
    public class ThicknessConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();
            return Common.ThicknessUtils.CalcThickness(valueStr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Thickness source= (Thickness)value;
            return $"{source.Left}, {source.Top}, {source.Right}, {source.Bottom}";
        }
    }

}
