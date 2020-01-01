using System;
using System.Globalization;
using Xamarin.Forms;

/// <summary>
/// V 1.0.0 - 2019-10-28 17:53:49
/// 首次创建
/// </summary>
namespace Util.XamariN.Converters
{
    public class KeyboardConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valueStr = (value ?? string.Empty).ToString();

            Keyboard matchKeyboard = Keyboard.Default;

            System.Reflection.PropertyInfo propInfo = typeof(Keyboard).GetProperty(valueStr);
            if (propInfo != null)
            {
                matchKeyboard = (Keyboard)propInfo.GetValue(null); // 静态属性传 null 即可
            }

            return matchKeyboard;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return string.Empty;
            }

            if (value is Xamarin.Forms.Keyboard == false)
            {
                return string.Empty;
            }
            else
            {
                Xamarin.Forms.Keyboard keyboard = value as Xamarin.Forms.Keyboard;
                Type t = keyboard.GetType();
                string r = t.Name.Replace("Keyboard", "");
                return r;
            }
        }
    }
}
