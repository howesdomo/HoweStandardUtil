using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.6 - 2020-07-23 17:53:19
    /// 新闻滚动条 ( 采用Animation方式实现 )(目前较满意版本)
    /// 
    /// 
    /// V 1.0.0 - V 1.0.5 - 2020-7-24 12:05:30 停用
    /// 使用 Render方式的跑马灯由于不能自己控制停顿 / 速度等诸多因素已于
    /// Util.XamariN.AndroiD.Components.MarqueeLabelRenderer 已被注释
    /// </summary>
    public class MarqueeLabel : ScrollView
    {
        #region Text

        public static readonly BindableProperty TextProperty = BindableProperty.Create
        (
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(MarqueeLabel),
            propertyChanged: textPropertyChanged
        );

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        private static void textPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            string value = newValue as string;
            if (oldValue as string == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.Text = value;
        }

        #endregion

        #region FontSize

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create
        (
            propertyName: "FontSize",
            returnType: typeof(double),
            declaringType: typeof(MarqueeLabel),
            validateValue: fontSize_IsValidValue,
            propertyChanged: fontSizePropertyChanged
        );

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static bool fontSize_IsValidValue(BindableObject view, object value)
        {
            double v;

            if (double.TryParse(value.ToString(), out v) == false)
            {
                return false;
            }
            // throw new Exception("每秒阅读字数不能小于1");
            return v > 0 ? true : false;
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            double value = (double)newValue;
            if ((double)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.FontSize = value;
        }

        #endregion

        #region Padding

        public new static readonly BindableProperty PaddingProperty = BindableProperty.Create
        (
            propertyName: "Padding",
            returnType: typeof(Thickness),
            declaringType: typeof(MarqueeLabel),
            validateValue: padding_IsValidValue,
            propertyChanged: paddingPropertyChanged
        );

        public new Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }

        private static bool padding_IsValidValue(BindableObject view, object value)
        {
            return value is Thickness;
        }

        private static void paddingPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Thickness value = (Thickness)newValue;
            if ((Thickness)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.Padding = value;
        }

        #endregion

        #region TextColor

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create
        (
            propertyName: "TextColor",
            returnType: typeof(Color),
            declaringType: typeof(MarqueeLabel),
            validateValue: textColor_IsValidValue,
            propertyChanged: textColorPropertyChanged
        );

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static bool textColor_IsValidValue(BindableObject view, object value)
        {
            return value is Color;
        }

        private static void textColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Color value = (Color)newValue;
            if ((Color)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.TextColor = value;
        }

        #endregion

        #region FontFamily

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create
        (
            propertyName: "FontFamily",
            returnType: typeof(string),
            declaringType: typeof(MarqueeLabel),
            validateValue: fontFamily_IsValidValue,
            propertyChanged: fontFamilyPropertyChanged
        );

        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        private static bool fontFamily_IsValidValue(BindableObject view, object value)
        {
            string v = value.ToString();
            return v.IsNullOrWhiteSpace() == false;
        }

        private static void fontFamilyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            string value = (string)newValue;
            if ((string)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.FontFamily = value;
        }

        #endregion

        #region FontAttributes

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create
        (
            propertyName: "FontAttributes",
            returnType: typeof(Xamarin.Forms.FontAttributes),
            declaringType: typeof(MarqueeLabel),
            validateValue: fontAttributes_IsValidValue,
            propertyChanged: fontAttributesPropertyChanged
        );

        public Xamarin.Forms.FontAttributes FontAttributes
        {
            get { return (Xamarin.Forms.FontAttributes)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        private static bool fontAttributes_IsValidValue(BindableObject view, object value)
        {
            return value is Xamarin.Forms.FontAttributes;
        }

        private static void fontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Xamarin.Forms.FontAttributes value = (Xamarin.Forms.FontAttributes)newValue;
            if ((Xamarin.Forms.FontAttributes)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.FontAttributes = value;
        }

        #endregion

        #region TextDecorations

        public static readonly BindableProperty TextDecorationsProperty = BindableProperty.Create
        (
            propertyName: "TextDecorations",
            returnType: typeof(Xamarin.Forms.TextDecorations),
            declaringType: typeof(MarqueeLabel),
            validateValue: textDecorations_IsValidValue,
            propertyChanged: textDecorationsPropertyChanged
        );

        public Xamarin.Forms.TextDecorations TextDecorations
        {
            get { return (Xamarin.Forms.TextDecorations)GetValue(TextDecorationsProperty); }
            set { SetValue(TextDecorationsProperty, value); }
        }

        private static bool textDecorations_IsValidValue(BindableObject view, object value)
        {
            return value is Xamarin.Forms.TextDecorations;
        }

        private static void textDecorationsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Xamarin.Forms.TextDecorations value = (Xamarin.Forms.TextDecorations)newValue;
            if ((Xamarin.Forms.TextDecorations)oldValue == value)
            {
                return;
            }

            (bindable as MarqueeLabel).label.TextDecorations = value;
        }

        #endregion

        #region WordsPerSecond -- 每秒阅读字数

        public static readonly BindableProperty WordsPerSecondProperty = BindableProperty.Create
        (
            propertyName: "WordsPerSecond",
            returnType: typeof(int),
            declaringType: typeof(MarqueeLabel),
            defaultValue: 7,
            validateValue: wordsPerSecond_IsValidValue,
            propertyChanged: wordsPerSecondPropertyChanged
        );

        public int WordsPerSecond
        {
            get { return (int)GetValue(WordsPerSecondProperty); }
            set { SetValue(WordsPerSecondProperty, value); }
        }

        private static bool wordsPerSecond_IsValidValue(BindableObject view, object value)
        {
            if (int.TryParse(value.ToString(), out int v) == false)
            {
                return false;
            }
            // throw new Exception("每秒阅读字数不能小于1");
            return v > 1 ? true : false;
        }

        private static void wordsPerSecondPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((int)oldValue == (int)newValue)
            {
                return;
            }

            (bindable as MarqueeLabel).beginAnimation();
        }

        #endregion

        #region StartBreakSecond -- 开始阅读停顿秒数

        public static readonly BindableProperty StartBreakSecondProperty = BindableProperty.Create
        (
            propertyName: "StartBreakSecond",
            returnType: typeof(double),
            declaringType: typeof(MarqueeLabel),
            defaultValue: 1d,
            validateValue: startBreakSecond_IsValidValue,
            propertyChanged: startBreakSecondPropertyChanged
        );

        public double StartBreakSecond
        {
            get { return (double)GetValue(StartBreakSecondProperty); }
            set { SetValue(StartBreakSecondProperty, value); }
        }

        private static bool startBreakSecond_IsValidValue(BindableObject view, object value)
        {
            if (double.TryParse(value.ToString(), out double v) == false)
            {
                return false;
            }
            // throw new Exception("开始阅读停顿秒数不能小于零");
            return v >= 0 ? true : false;
        }

        private static void startBreakSecondPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((double)oldValue == (double)newValue)
            {
                return;
            }

            (bindable as MarqueeLabel).beginAnimation();
        }

        #endregion

        #region EndBreakSecond -- 完成阅读停顿秒数

        public static readonly BindableProperty EndBreakSecondProperty = BindableProperty.Create
        (
            propertyName: "EndBreakSecond",
            returnType: typeof(double),
            declaringType: typeof(MarqueeLabel),
            defaultValue: 1d,
            validateValue: endBreakSecond_IsValidValue,
            propertyChanged: endBreakSecondPropertyChanged
        );

        public double EndBreakSecond
        {
            get { return (double)GetValue(EndBreakSecondProperty); }
            set { SetValue(EndBreakSecondProperty, value); }
        }

        private static bool endBreakSecond_IsValidValue(BindableObject view, object value)
        {
            if (double.TryParse(value.ToString(), out double v) == false)
            {
                return false;
            }
            // throw new Exception("完成阅读停顿秒数不能小于零");
            return v >= 0 ? true : false;
        }

        private static void endBreakSecondPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((double)oldValue == (double)newValue)
            {
                return;
            }

            (bindable as MarqueeLabel).beginAnimation();
        }

        #endregion

        #region ResetSecond -- 回滚重置持续秒数

        public static readonly BindableProperty ResetSecondProperty = BindableProperty.Create
        (
            propertyName: "ResetSecond",
            returnType: typeof(double),
            declaringType: typeof(MarqueeLabel),
            defaultValue: 1d,
            validateValue: resetSecond_IsValidValue,
            propertyChanged: resetSecondPropertyChanged
        );

        public double ResetSecond
        {
            get { return (double)GetValue(ResetSecondProperty); }
            set { SetValue(ResetSecondProperty, value); }
        }

        private static bool resetSecond_IsValidValue(BindableObject view, object value)
        {
            if (double.TryParse(value.ToString(), out double v) == false)
            {
                return false;
            }
            // throw new Exception("回滚重置持续秒数不能小于零");
            return v >= 0 ? true : false;
        }

        private static void resetSecondPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((double)oldValue == (double)newValue)
            {
                return;
            }

            (bindable as MarqueeLabel).beginAnimation();
        }

        #endregion

        /// <summary>
        /// 当前状态是否已跑马灯形式呈现 
        /// true 跑马灯 | false 静态 
        /// </summary>
        public bool IsMarqueeState
        {
            get { return mStoryboard != null ? true : false; }
        }

        #region 完成阅读通知事件

        /// <summary>
        /// 完成阅读通知
        /// </summary>
        public event EventHandler<EventArgs> ReadCompleted;

        private void onReadCompleted()
        {
            if (ReadCompleted != null)
            {
                this.ReadCompleted.Invoke(this, new EventArgs());
            }
        }

        #endregion

        #region 回滚重置通知事件

        /// <summary>
        /// 回滚重置通知事件, 信息回滚到最开始后通知
        /// </summary>
        public EventHandler<EventArgs> ResetCompleted;

        private void onResetCompleted()
        {
            if (ResetCompleted != null)
            {
                this.ResetCompleted.Invoke(this, new EventArgs());
            }
        }

        #endregion

        Label label;

        public MarqueeLabel()
        {
            initUI();
            initEvent();
        }

        void initUI()
        {
            HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
            Orientation = ScrollOrientation.Horizontal;

            label = new Label();
            label.HorizontalOptions = LayoutOptions.FillAndExpand;
            label.LineBreakMode = LineBreakMode.NoWrap;

            this.Content = label;
        }

        void initEvent()
        {
            this.SizeChanged += MarqueeLabel_SizeChanged;
            label.SizeChanged += Label_SizeChanged;
        }

        private void Label_SizeChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Label_SizeChanged");
            beginAnimation();
        }

        private void MarqueeLabel_SizeChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("MarqueeLabel_SizeChanged");
            beginAnimation();
        }

        Util.ActionUtils.DebounceAction DebounceAction { get; set; } = new Util.ActionUtils.DebounceAction();

        void beginAnimation()
        {
            DebounceAction.Debounce
            (
                interval: 300,
                action: () =>
                {
                    beginAnimation_ActualMethod();
                },
                syncInvoke: null
            );
        }

        void beginAnimation_ActualMethod()
        {
            if (this.Width >= label.Width)
            {
                //string msg = $"无需使用滚动方式显示";
                //System.Diagnostics.Debug.WriteLine(msg);
                return;
            }

            if (mStoryboard != null)
            {
                try
                {
                    label.AbortAnimation(mAnimationName);
                }
                finally
                {
                    mStoryboard = null;
                }
            }

            NewsTicker();
        }

        #region 新闻滚动条

        /// <summary>
        /// 新闻滚动条动画名称, 用于取消动画
        /// </summary>
        string mAnimationName
        {
            get
            {
                return "NewsTicker";
            }
        }

        Animation mStoryboard { get; set; }

        void NewsTicker()
        {
            if (mStoryboard != null)
            {
                return;
            }

            double wordsPerSecode = double.Parse(this.WordsPerSecond.ToString());
            double wordsTotalSeconds = Convert.ToDouble(label.Text.Length) / wordsPerSecode;
            double startBreakSecond = this.StartBreakSecond;
            double endBreakSecond = this.EndBreakSecond;
            double resetSecond = this.ResetSecond;

            double totalSeconds = startBreakSecond + wordsTotalSeconds + endBreakSecond + resetSecond;

            mStoryboard = new Animation();

            // 1. 开始阅读停顿
            Animation s0 = new Animation
            (
                callback: v => label.TranslationX = v,
                start: 0,
                end: 0,
                easing: Easing.Linear,
                finished: null
            );

            mStoryboard.Add(0, startBreakSecond / totalSeconds, s0);

            // 2. 开始阅读
            Animation s1 = new Animation
            (
                callback: v => label.TranslationX = v,
                start: 0,
                end: -label.Width + (this.Width - label.Padding.Left),
                easing: Easing.Linear,
                finished: null
            );

            mStoryboard.Add(startBreakSecond / totalSeconds, (startBreakSecond + wordsTotalSeconds) / totalSeconds, s1);

            // 3. 完成阅读开始阅读后停顿
            Animation s2 = new Animation
            (
                callback: v => label.TranslationX = v,
                start: -label.Width + (this.Width - label.Padding.Left),
                end: -label.Width + (this.Width - label.Padding.Left),
                easing: Easing.Linear,
                finished: () => { onReadCompleted(); }
            );

            mStoryboard.Add((startBreakSecond + wordsTotalSeconds) / totalSeconds, (startBreakSecond + wordsTotalSeconds + endBreakSecond) / totalSeconds, s2);

            // 4. 回滚到最开头
            Animation s3 = new Animation
            (
                callback: v => label.TranslationX = v,
                start: -label.Width + (this.Width - label.Padding.Left),
                end: 0,
                easing: Easing.Linear,
                finished: () => { onResetCompleted(); }
            );

            mStoryboard.Add((startBreakSecond + wordsTotalSeconds + endBreakSecond) / totalSeconds, 1, s3);

            // 执行动画
            mStoryboard.Commit(label, mAnimationName, 16, uint.Parse((Math.Ceiling(totalSeconds) * 1000).ToString()), Easing.Linear, null, () => { return true; });
        }

        #endregion

    }
}
