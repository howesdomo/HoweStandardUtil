using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/// <summary>
/// V 1.0.1 - 2019-10-29 11:57:09
/// 修改名称为 XxxSimpleConvert, 表示不编写 ConvertBack 的逻辑
/// 
/// V 1.0.0 - 2019-10-28 17:34:53
/// DateTime, Date, Time 简单的转换器 ( 不进行 ConvertBack 的实现 )
/// </summary>
namespace Util.XamariN.Converters
{
    /// <summary>
    /// 设计思路
    /// 在初始化构造函数时, 按照项目要求修改本类中的 各个Template, 即可适应于各个不同的项目
    /// 若存在某些特殊情况, 请在各自的实际项目中编写转换器
    /// </summary>
    public class DateTimeConverterStaticInfo
    {
        public static string DateTimeTemplate { get; set; } = "yyyy-MM-dd HH:mm:ss.fff";

        public static string DateTemplate { get; set; } = "yyyy-MM-dd";

        public static string TimeTemplate { get; set; } = "HH:mm:ss.fff";
    }

    public class DateTimeSimpleConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).ToString(DateTimeConverterStaticInfo.DateTimeTemplate);
            }
            else if (value is DateTime?)
            {
                var target = (DateTime?)value;
                if (target.HasValue)
                {
                    return target.Value.ToString(DateTimeConverterStaticInfo.DateTimeTemplate);
                }
                else
                {
                    return string.Empty;
                }
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

    public class DateSimpleConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).ToString(DateTimeConverterStaticInfo.DateTemplate);
            }
            else if (value is DateTime?)
            {
                var target = (DateTime?)value;
                if (target.HasValue)
                {
                    return target.Value.ToString(DateTimeConverterStaticInfo.DateTemplate);
                }
                else
                {
                    return string.Empty;
                }
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

    public class TimeSimpleConverter : Xamarin.Forms.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime)
            {
                return ((DateTime)value).ToString(DateTimeConverterStaticInfo.TimeTemplate);
            }
            else if (value is DateTime?)
            {
                var target = (DateTime?)value;
                if (target.HasValue)
                {
                    return target.Value.ToString(DateTimeConverterStaticInfo.TimeTemplate);
                }
                else
                {
                    return string.Empty;
                }
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
