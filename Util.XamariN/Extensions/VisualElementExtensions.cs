using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms
{
    /// <summary>
    /// V 1.0.0 - 2020-08-02 16:32:14
    /// 补充动画扩展方法
    /// </summary>
    public static class VisualElementExtensions
    {
        #region Animation ColorTo (动画变换颜色)

        // 使用示例 await frame.ColorTo(fromColor, toColor, callBackColor => frame.BackgroundColor = callBackColor, Convert.ToUInt32(300), Easing.CubicOut);


        public static Task<bool> ColorTo(this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing easing = null)
        {
            Color transform(double t) =>
                Color.FromRgba(fromColor.R + t * (toColor.R - fromColor.R),
                               fromColor.G + t * (toColor.G - fromColor.G),
                               fromColor.B + t * (toColor.B - fromColor.B),
                               fromColor.A + t * (toColor.A - fromColor.A));

            return ColorAnimation(self, "ColorTo", transform, callback, length, easing);
        }

        public static void CancelAnimation(this VisualElement self)
        {
            self.AbortAnimation("ColorTo");
        }

        static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing)
        {
            easing = easing ?? Easing.Linear;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            element.Animate<Color>(name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));

            return taskCompletionSource.Task;
        }

        #endregion
    }
}
