using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Util.XamariN.Converters
{
    public class TimeSpanSimpleConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeSpan)
            {
                return ((TimeSpan)value).ToStringAdv();
            }
            else if (value is TimeSpan?)
            {
                var target = (value as TimeSpan?);
                if (target.HasValue) { return target.Value.ToStringAdv(); }
                else { return string.Empty; }
            }
            else
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
