[assembly: Xamarin.Forms.ExportRenderer(typeof(Util.XamariN.Components.MarqueeLabel), typeof(Util.XamariN.AndroiD.Components.MarqueeLabelRenderer))]
namespace Util.XamariN.AndroiD.Components
{
    public class MarqueeLabelRenderer : Xamarin.Forms.Platform.Android.LabelRenderer
    {
        public MarqueeLabelRenderer(Android.Content.Context context) : base(context)
        {

        }

        //// 安卓源码 Marquee 启动条件                
        //@Override
        //public void setSelected(boolean selected)
        //{
        //    boolean wasSelected = isSelected();
        //
        //    super.setSelected(selected);
        //
        //    if (selected != wasSelected && mEllipsize == TextUtils.TruncateAt.MARQUEE)
        //    {
        //        if (selected)
        //        {
        //            startMarquee();
        //        }
        //        else
        //        {
        //            stopMarquee();
        //        }
        //    }
        //}

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) // 初始化时进入 if
            {
                Control.Ellipsize = Android.Text.TextUtils.TruncateAt.Marquee;
                Control.SetMarqueeRepeatLimit(-1); // -1 代表跑马灯无限循环
                Control.FocusableInTouchMode = true;
                Control.SetHorizontallyScrolling(true);
                Control.SetSingleLine(true);

                // Control.SetFocusable(Android.Views.ViewFocusability.Focusable); // 执行报错 // 不用这个属性也能实现 Marquee 效果

                Control.Selected = true; // 核心代码
            }
        }
    }
}