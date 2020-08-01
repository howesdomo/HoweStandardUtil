using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;

namespace Util.XamariN.Behaviors
{
    /// <summary>
    /// V 1.0.0 - 2020-08-01 08:54:39
    /// 各种 View 模拟 Button 点击效果
    /// </summary>
    public class ViewTapLikeButtonBehavior : Behavior<View>
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
                    Color oldColor = default(Color);
                    var labelView = sender as Label;

                    if (labelView != null)
                    {
                        oldColor = labelView.TextColor;
                        labelView.TextColor = Color.Black;
                    }

                    //await view.ScaleTo(0.85d, Configuration.ClickFadeDuration / 2, Easing.SinIn); // 注释 By Howe
                    //await view.ScaleTo(1d, Configuration.ClickFadeDuration / 2, Easing.SinIn); // 注释 By Howe

                    await view.ScaleTo(0.85d, 250, Easing.SinIn);
                    await view.ScaleTo(1d, 250, Easing.SinIn);

                    if (labelView != null)
                    {
                        labelView.TextColor = oldColor;
                    }
                }
                finally
                {
                    mIsAnimating = false;
                }
            });
        }
    }
}
