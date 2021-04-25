using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;
using Xamarin.Forms.Xaml;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.0 - 2021-04-25 17:43:08
    /// 首次创建, 用于统一各个平台的等待指示器样式
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UcBusyIndicator : ContentView
    {
        public UcBusyIndicator()
        {
            InitializeComponent();

            setContent(BusyContent);
        }

        void setContent(string v)
        {
            this.txtMsg.Text = v;
            setDock();
        }

        /// <summary>
        /// 设置 BusyContent 停靠位置
        /// </summary>
        void setDock()
        {
            switch (BusyContentDock)
            {
                case Dock.Left:
                    {
                        if (BusyContent.IsNullOrWhiteSpace())
                        {
                            gMain.ColumnDefinitions[0].Width = new GridLength(0.5d, GridUnitType.Star);
                            gMain.ColumnDefinitions[2].Width = new GridLength(0.5d, GridUnitType.Star);
                        }
                        else
                        {
                            gMain.ColumnDefinitions[0].Width = new GridLength(0.7d, GridUnitType.Star);
                            gMain.ColumnDefinitions[2].Width = new GridLength(0.3d, GridUnitType.Star);
                        }

                        Grid.SetRow(this.txtMsg, 1);
                        Grid.SetColumn(this.txtMsg, 0);
                        this.txtMsg.HorizontalTextAlignment = TextAlignment.End;
                        this.txtMsg.VerticalTextAlignment = TextAlignment.Center;
                        this.txtMsg.Margin = new Thickness(0, 0, 10, 0);
                    }
                    break;
                case Dock.Top:
                    {
                        gMain.ColumnDefinitions[0].Width = new GridLength(0.5d, GridUnitType.Star);
                        gMain.ColumnDefinitions[2].Width = new GridLength(0.5d, GridUnitType.Star);

                        Grid.SetRow(this.txtMsg, 0);
                        Grid.SetColumn(this.txtMsg, 1);
                        this.txtMsg.HorizontalTextAlignment = TextAlignment.Center;
                        this.txtMsg.VerticalTextAlignment = TextAlignment.End;
                        this.txtMsg.Margin = new Thickness(0, 0, 0, 10);
                    }
                    break;

                case Dock.Bottom:
                    {
                        gMain.ColumnDefinitions[0].Width = new GridLength(0.5d, GridUnitType.Star);
                        gMain.ColumnDefinitions[2].Width = new GridLength(0.5d, GridUnitType.Star);

                        Grid.SetRow(this.txtMsg, 2);
                        Grid.SetColumn(this.txtMsg, 1);
                        this.txtMsg.HorizontalTextAlignment = TextAlignment.Center;
                        this.txtMsg.VerticalTextAlignment = TextAlignment.Start;
                        this.txtMsg.Margin = new Thickness(0, 10, 0, 0);
                    }
                    break;
                case Dock.Right:
                default:
                    {
                        if (BusyContent.IsNullOrWhiteSpace())
                        {
                            gMain.ColumnDefinitions[0].Width = new GridLength(0.5d, GridUnitType.Star);
                            gMain.ColumnDefinitions[2].Width = new GridLength(0.5d, GridUnitType.Star);
                        }
                        else
                        {
                            gMain.ColumnDefinitions[0].Width = new GridLength(0.3d, GridUnitType.Star);
                            gMain.ColumnDefinitions[2].Width = new GridLength(0.7d, GridUnitType.Star);
                        }

                        Grid.SetRow(this.txtMsg, 1);
                        Grid.SetColumn(this.txtMsg, 2);
                        this.txtMsg.HorizontalTextAlignment = TextAlignment.Start;
                        this.txtMsg.VerticalTextAlignment = TextAlignment.Center;
                        this.txtMsg.Margin = new Thickness(10, 0, 0, 0);
                    }
                    break;
            }
        }

        private void execute()
        {
            if (this.IsBusy)
            {
                this.busyIndicator.IsVis = true;
                this.InputTransparent = false;
                this.gWait.IsVisible = true;
            }
            else
            {
                this.busyIndicator.IsVis = false;
                this.InputTransparent = true;
                this.gWait.IsVisible = false;
            }

            if (IsResetBusyContentPerExecute)
            {
                this.BusyContent = DefalutBusyContent;
            }
        }

        #region [DP] IsBusy

        public static readonly BindableProperty IsBusyProperty = BindableProperty.Create
        (
            propertyName: "IsBusy",
            returnType: typeof(bool),
            declaringType: typeof(UcBusyIndicator),
            propertyChanged: onIsBusy_PropertyChangedCallback
        );

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }

        private static void onIsBusy_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.execute();
            }
        }

        #endregion

        private static string sbc { get { return "请稍候..."; } }

        #region [DP] Defalut_BusyContent

        public static readonly BindableProperty DefalutBusyContentProperty = BindableProperty.Create
        (
            propertyName: "DefalutBusyContent",
            returnType: typeof(string),
            declaringType: typeof(UcBusyIndicator),
            defaultValue: sbc,
            propertyChanged: onIsBusy_PropertyChangedCallback
        );

        /// <summary>
        /// 若设置 IsResetBusyContentPerExecute = True 时 (默认值为 True )
        /// 每次执行都会重置 BusyContent 信息成为 DefaultBusyContent
        /// </summary>
        public string DefalutBusyContent
        {
            get { return (string)GetValue(DefalutBusyContentProperty); }
            set { SetValue(DefalutBusyContentProperty, value); }
        }

        #endregion

        #region [DP] BusyContent

        public static readonly BindableProperty BusyContentProperty = BindableProperty.Create
        (
            propertyName: "BusyContent",
            returnType: typeof(string),
            declaringType: typeof(UcBusyIndicator),
            defaultValue: sbc,
            propertyChanged: onBusyContent_PropertyChangedCallback
        );


        public string BusyContent
        {
            get { return (string)GetValue(BusyContentProperty); }
            set { SetValue(BusyContentProperty, value); }
        }

        private static void onBusyContent_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.setContent(newValue.ToString());
            }
        }

        #endregion

        #region [DP] IsResetBusyContentPerExecute

        public static readonly BindableProperty IsResetBusyContentPerExecuteProperty = BindableProperty.Create
        (
            propertyName: "IsResetBusyContentPerExecute",
            returnType: typeof(bool),
            declaringType: typeof(UcBusyIndicator),
            defaultValue: true,
            propertyChanged: null
        );

        /// <summary>
        /// 每次显示完毕后是否重置 BusyContent 信息
        /// </summary>
        public bool IsResetBusyContentPerExecute
        {
            get { return (bool)GetValue(IsResetBusyContentPerExecuteProperty); }
            set { SetValue(IsResetBusyContentPerExecuteProperty, value); }
        }

        #endregion

        #region [dp] BusyContentDock

        public static readonly BindableProperty BusyContentDockProperty = BindableProperty.Create
        (
            propertyName: "BusyContentDock",
            returnType: typeof(Dock),
            declaringType: typeof(UcBusyIndicator),
            propertyChanged: onBusyContentDock_PropertyChangedCallback
        );

        public Dock BusyContentDock
        {
            get { return (Dock)GetValue(BusyContentDockProperty); }
            set { SetValue(BusyContentDockProperty, value); }
        }

        private static void onBusyContentDock_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.setDock();
            }
        }

        #endregion

        // 将 BusyIndicator 的 DP 暴露给程序员使用
        #region [DP] BusyIndicatorPathData <- BusyIndicator [DP] PathData

        public static readonly BindableProperty BusyIndicatorPathDataProperty = BindableProperty.Create
        (
            propertyName: "BusyIndicatorPathData",
            returnType: typeof(string),
            declaringType: typeof(UcBusyIndicator),
            propertyChanged: onBusyIndicatorPathData_PropertyChangedCallback
        );

        public string BusyIndicatorPathData
        {
            get { return (string)GetValue(BusyIndicatorPathDataProperty); }
            set { SetValue(BusyIndicatorPathDataProperty, value); }
        }

        private static void onBusyIndicatorPathData_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.busyIndicator.PathData = newValue.ToString();
            }
        }

        #endregion

        #region [DP] BusyIndicatorStroke <- BusyIndicator [DP] PathStroke

        public static readonly BindableProperty BusyIndicatorStrokeProperty = BindableProperty.Create
        (
            propertyName: "BusyIndicatorStroke",
            returnType: typeof(SolidColorBrush),
            declaringType: typeof(UcBusyIndicator),
            propertyChanged: onBusyIndicatorStroke_PropertyChangedCallback
        );

        public SolidColorBrush BusyIndicatorStroke
        {
            get { return (SolidColorBrush)GetValue(BusyIndicatorStrokeProperty); }
            set { SetValue(BusyIndicatorStrokeProperty, value); }
        }

        public static void onBusyIndicatorStroke_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.busyIndicator.PathStroke = (SolidColorBrush)newValue;
            }
        }

        #endregion

        #region [DP] BusyIndicatorFill -- BusyIndicator [DP] PathFill

        public static readonly BindableProperty BusyIndicatorFillProperty = BindableProperty.Create
        (
            propertyName: "BusyIndicatorFill",
            returnType: typeof(SolidColorBrush),
            declaringType: typeof(UcBusyIndicator),
            propertyChanged: onBusyIndicatorFill_PropertyChangedCallback
        );

        public SolidColorBrush BusyIndicatorFill
        {
            get { return (SolidColorBrush)GetValue(BusyIndicatorFillProperty); }
            set { SetValue(BusyIndicatorFillProperty, value); }
        }

        public static void onBusyIndicatorFill_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                target.busyIndicator.PathFill = (SolidColorBrush)newValue;
            }
        }

        #endregion

        #region [DP] BusyIndicatorScale <- BusyIndicator [DP] IndicatorScale

        public static readonly BindableProperty BusyIndicatorScaleProperty = BindableProperty.Create
        (
            propertyName: "BusyIndicatorScale",
            returnType: typeof(double),
            declaringType: typeof(UcBusyIndicator),
            defaultValue: 1d,
            propertyChanged: onBusyIndicatorScale_PropertyChangedCallback
        );

        public double BusyIndicatorScale
        {
            get { return (double)GetValue(BusyIndicatorScaleProperty); }
            set { SetValue(BusyIndicatorScaleProperty, value); }
        }

        public static void onBusyIndicatorScale_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is UcBusyIndicator target)
            {
                if (double.TryParse(newValue.ToString(), out double value) == true)
                {
                    target.busyIndicator.PathScale = value;
                }
            }
        }

        #endregion

        /// <summary>
        /// BusyContent 停靠点
        /// </summary>
        public enum Dock
        {
            Right,
            Bottom,
            Left,
            Top
        }
    }

    /// <summary>
    /// 指示器动画
    /// </summary>
    class BusyIndicator : Grid
    {
        public double mMaxOpacity = 1d;
        public double mMinOpacity = 0.2d;

        /// <summary>
        /// 动画名称
        /// </summary>
        public const string AnimationName = "PathAnimation";

        List<Xamarin.Forms.Shapes.Path> mPathList { get; set; } = new List<Path>();

        List<Xamarin.Forms.Shapes.ScaleTransform> mSTList { get; set; } = new List<ScaleTransform>();

        List<Xamarin.Forms.Animation> mAnimationList { get; set; } = new List<Animation>();

        PathGeometryConverter mGeometryConverter { get; set; } = new PathGeometryConverter();

        public BusyIndicator()
        {
            //// 设定了 40, 能解决关闭后再次打开
            // this.WidthRequest = 40;
            // this.HeightRequest = 40;
        }

        void start()
        {
            for (int i = 0; i < 10; i++)
            {
                var p = new Xamarin.Forms.Shapes.Path();
                p.Aspect = Stretch.None;

                mPathList.Add(p);
                this.Children.Add(p);
                p.Data = (Geometry)mGeometryConverter.ConvertFromInvariantString("M 0,20 L 0.8,19 L 10,19 L 10,21 L 0.8,21 Z"); // XamarinForms 版本貌似不能显示负数的内容, 故起始由9点方位的横线开始

                p.Stroke = new SolidColorBrush(Color.White);
                p.Fill = new SolidColorBrush(Color.White);
                p.Opacity = mMinOpacity;

                var tg = new TransformGroup();
                // TransformGroup 需要进行 2个步骤
                // 1 向上位移 50 ==> Y = -50;
                // 2 旋转一定角度, 让 12 个 Path 组成一个圆 ==> Angle = i * 30;

                var tt = new TranslateTransform();
                // tt.Y = -13; // WPF
                tt.X = 2; // 可以调整的范围 0 ~ 5
                tg.Children.Add(tt);

                var rt = new RotateTransform();
                rt.Angle = i * 36; // 360 / 10 = 36
                rt.CenterX = 20; // XamarinForms 版本貌似不能显示负数的内容, 故起始由9点方位的横线开始, 所以旋转以 20, 20 为中心
                rt.CenterY = 20; // XamarinForms 版本貌似不能显示负数的内容, 故起始由9点方位的横线开始, 所以旋转以 20, 20 为中心
                tg.Children.Add(rt);

                var st = new ScaleTransform();
                mSTList.Add(st); // 程序员可以调整缩放
                st.ScaleX = 1;
                st.ScaleY = 1;
                tg.Children.Add(st);

                p.RenderTransform = tg;

                //var ani = new DoubleAnimation();
                //ani.From = mMaxOpacity;
                //ani.To = mMinOpacity;
                //ani.Duration = new Duration(TimeSpan.FromSeconds(1));

                //// 为了实现依次闪烁, 错开每个动画的开始时间
                //ani.BeginTime = TimeSpan.FromMilliseconds(i * 1000 / 12);
                //ani.RepeatBehavior = System.Windows.Media.Animation.RepeatBehavior.Forever;

                //p.BeginAnimation(System.Windows.Shapes.Path.OpacityProperty, ani);

                Animation mStoryboard = new Animation();

                // double total = 6000d;
                double total = 1000d;

                double k1 = i * 100d / total;

                // 等待动画开始执行
                if (i > 0)
                {
                    Animation s1 = new Animation
                    (
                        callback: v => p.Opacity = v,
                        start: mMinOpacity,
                        end: mMinOpacity,
                        easing: Easing.Linear,
                        finished: null
                    );

                    mStoryboard.Add
                    (
                        beginAt: 0,
                        finishAt: k1,
                        animation: s1
                    );
                }

                // 动画开始执行
                Animation s2 = new Animation
                (
                    callback: v => p.Opacity = v,
                    start: mMaxOpacity,
                    end: mMinOpacity,
                    easing: Easing.Linear,
                    finished: null
                );

                mStoryboard.Add
                (
                    beginAt: k1,
                    finishAt: 1,
                    animation: s2
                );

                mStoryboard.Commit
                (
                    owner: p,
                    name: AnimationName,
                    rate: 16,
                    length: uint.Parse(total.ToString()),
                    easing: Easing.Linear,
                    finished: null,
                    repeat: () => { return true; }
                );

                mAnimationList.Add(mStoryboard);
            }
        }

        void stop()
        {
            mPathList.ForEach(p => p.AbortAnimation(AnimationName));
            this.Children.Clear();

            mPathList.Clear();
            mSTList.Clear();
            mAnimationList.Clear();
        }

        // TODO IsVis
        #region [DP] IsVis

        public static readonly BindableProperty IsVisProperty = BindableProperty.Create
        (
            propertyName: "IsVis",
            returnType: typeof(bool),
            declaringType: typeof(BusyIndicator),
            propertyChanged: onIsVis_PropertyChangedCallback
        );

        public bool IsVis
        {
            get { return (bool)GetValue(IsVisProperty); }
            set { SetValue(IsVisProperty, value); }
        }

        private readonly object _LOCK_ = new object();

        public static void onIsVis_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            // TODO
            //lock (_LOCK_)
            //{
            if (bindable is BusyIndicator target)
            {
                if (newValue is bool v)
                {
                    if (v)
                    {
                        target.start();
                    }
                    else
                    {
                        target.stop();
                    }
                }
            }
            //}
        }

        #endregion

        #region [DP] PathData - 可以修改等待图案的样式

        public static readonly BindableProperty PathDataProperty = BindableProperty.Create
        (
            propertyName: "PathData",
            returnType: typeof(string),
            declaringType: typeof(BusyIndicator),
            propertyChanged: onPathData_PropertyChangedCallback
        );

        public string PathData
        {
            get { return (string)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static void onPathData_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BusyIndicator target)
            {
                foreach (var path in target.mPathList)
                {
                    try
                    {
                        var pathData = (Geometry)target.mGeometryConverter.ConvertFromInvariantString(newValue.ToString());
                        path.Data = pathData;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        System.Diagnostics.Debugger.Break();
                    }
                }
            }
        }

        #endregion

        #region [DP] PathStroke - 可以修改等待图案的边框颜色

        public static readonly BindableProperty PathStrokeProperty = BindableProperty.Create
        (
            propertyName: "PathStroke",
            returnType: typeof(SolidColorBrush),
            declaringType: typeof(BusyIndicator),
            propertyChanged: onPathStroke_PropertyChangedCallback
        );

        public SolidColorBrush PathStroke
        {
            get { return (SolidColorBrush)GetValue(PathStrokeProperty); }
            set { SetValue(PathStrokeProperty, value); }
        }

        public static void onPathStroke_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BusyIndicator target)
            {
                foreach (var path in target.mPathList)
                {
                    path.Stroke = (SolidColorBrush)newValue;
                }
            }
        }

        #endregion

        #region [DP] PathFill - 可以修改等待图案的填充颜色

        public static readonly BindableProperty PathFillProperty = BindableProperty.Create
        (
            propertyName: "PathFill",
            returnType: typeof(SolidColorBrush),
            declaringType: typeof(BusyIndicator),
            propertyChanged: onPathFill_PropertyChangedCallback
        );

        public SolidColorBrush PathFill
        {
            get { return (SolidColorBrush)GetValue(PathFillProperty); }
            set { SetValue(PathFillProperty, value); }
        }

        public static void onPathFill_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BusyIndicator target)
            {
                foreach (var path in target.mPathList)
                {
                    path.Fill = (SolidColorBrush)newValue;
                }
            }
        }

        #endregion

        #region [DP] PathScale - 可以修改等待图案的缩放比例

        public static readonly BindableProperty PathScaleProperty = BindableProperty.Create
        (
            propertyName: "PathScale",
            returnType: typeof(double),
            declaringType: typeof(BusyIndicator),
            defaultValue: 1d,
            propertyChanged: onPathScale_PropertyChangedCallback
        );

        public double PathScale
        {
            get { return (double)GetValue(PathScaleProperty); }
            set { SetValue(PathScaleProperty, value); }
        }

        public static void onPathScale_PropertyChangedCallback(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BusyIndicator target)
            {
                double v = (double)newValue;
                foreach (var st in target.mSTList)
                {
                    st.ScaleX = v;
                    st.ScaleY = v;
                }
            }
        }

        #endregion
    }
}