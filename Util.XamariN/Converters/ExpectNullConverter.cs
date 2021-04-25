using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Util.XamariN.Converters
{
    /// <summary>
    /// <para>期望空值</para>
    /// <para>返回 bool</para>
    /// <para>空值 返回 true</para>
    /// <para>非空 返回 false</para>
    /// </summary>
    public class ExpectNullConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// <para>期望非空</para>
    /// <para>返回 bool</para>
    /// <para>空值 返回 false</para>
    /// <para>非空 返回 true</para>
    /// </summary>
    public class ExpectNotNullConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(value is null);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
