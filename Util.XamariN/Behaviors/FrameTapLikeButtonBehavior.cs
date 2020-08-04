using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace Util.XamariN.Behaviors
{
    /// <summary>
    /// V 1.0.0 - 2020-08-03 08:54:39
    /// Btn ( Frame + Label 模拟 Xamarin.Forms Button) 使用的模拟点击效果 Behavior
    /// </summary>
    public class FrameTapLikeButtonBehavior : Behavior<View>
    {
        protected override void OnAttachedTo(View bindable)
        {
            var exists = bindable.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;

            if (exists != null)
            {
                exists.Tapped += View_Tapped;
            }

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(View bindable)
        {
            var exists = bindable.GestureRecognizers.FirstOrDefault() as TapGestureRecognizer;

            if (exists != null)
            {
                exists.Tapped -= View_Tapped;
            }

            base.OnDetachingFrom(bindable);
        }

        bool mIsAnimating { get; set; } = false;

        void View_Tapped(object sender, EventArgs e)
        {
            if (mIsAnimating == true)
            {
                return;
            }

            mIsAnimating = true;

            var view = (View)sender;

            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    var frame = sender as Frame;

                    Color fromColor = frame.BackgroundColor;
                    Color toColor = Color.Silver;

                    await frame.ColorTo(fromColor, toColor, callBackColor => frame.BackgroundColor = callBackColor, Convert.ToUInt32(300), Easing.CubicOut);
                    await frame.ColorTo(toColor, fromColor, callBackColor => frame.BackgroundColor = callBackColor, Convert.ToUInt32(100));
                }
                finally
                {
                    mIsAnimating = false;
                }
            });
        }
    }
}
