using System;
using System.Globalization;
using Xamarin.Forms;

/// <summary>
/// V 1.0.1 - 2019-10-29 11:13:35
/// 修改名称为 XxxSimpleConvert, 表示不编写 ConvertBack 的逻辑
/// 
/// V 1.0.0 - 2019-10-28 17:53:49
/// 首次创建
/// </summary>
namespace Util.XamariN.Converters
{
    public class ImageSourceSimpleConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();
            return Common.ImageSourceUtils.String2ImageSource(valueStr);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
    

}
