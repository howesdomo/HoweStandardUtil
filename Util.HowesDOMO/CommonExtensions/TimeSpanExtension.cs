using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class TimeSpanExtension
    {
        /// <summary>
        /// 含毫秒信息
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static string ToStringAdv(this TimeSpan ts)
        {
            string r = string.Empty;

            if (ts.Days > 0)
            {
                r += $"{ts.Days}天";
            }

            if (ts.Hours > 0)
            {
                r += $"{ts.Hours}小时";
            }

            if (ts.Minutes > 0)
            {
                r += $"{ts.Minutes}分";
            }

            if (ts.Seconds > 0)
            {
                r += $"{ts.Seconds}秒";
            }

            if (ts.Milliseconds > 0)
            {
                r += $"{ts.Milliseconds}毫秒";
            }

            return r;
        }

        /// <summary>
        /// 不含毫秒信息
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static string ToStringAdvSimple(this TimeSpan ts)
        {
            string r = string.Empty;

            if (ts.Days > 0)
            {
                r += $"{ts.Days}天";
            }

            if (ts.Hours > 0)
            {
                r += $"{ts.Hours}小时";
            }

            if (ts.Minutes > 0)
            {
                r += $"{ts.Minutes}分";
            }

            if (ts.Seconds > 0)
            {
                r += $"{ts.Seconds}秒";
            }

            //if (ts.Milliseconds > 0)
            //{
            //    r += $"{ts.Milliseconds}毫秒";
            //}

            return r;
        }

        /// <summary>
        /// 用于 Xamarin.Forms 的动画持续时长计算
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static uint AnimationDuration_XamarinForms(this TimeSpan t)
        {
            double temp = t.TotalMilliseconds;
            return Convert.ToUInt32(temp);
        }
    }
}
