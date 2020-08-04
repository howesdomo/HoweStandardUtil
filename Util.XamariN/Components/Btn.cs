using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.0 - 2020-08-04 15:20:55
    /// Xamarin.Forms Button 的 Text 内容若需要换行
    /// 可以使用 2 种解决方法
    /// 1 在Text内容需要换行的位置加入 &#x0a; 进行换行
    /// 2 使用 Android / iOS Render 进行换行 ( 待深入研究 )
    /// 
    /// 本控件通过模拟 Button 控件效果
    /// </summary>
    public class Btn : Frame
    {
        Label label { get; set; }

        Image leftImage { get; set; }

        Image rightImage { get; set; }

        public Btn()
        {
            initUI();
        }

        void initUI()
        {
            var frame = this;

            frame.Margin = new Thickness(4, 0, 4, 2);
            frame.Padding = new Thickness(0, 5, 0, 5);
            frame.BackgroundColor = Color.LightGray;
            frame.CornerRadius = 2f;
            frame.HorizontalOptions = LayoutOptions.Start;
            frame.VerticalOptions = LayoutOptions.Start;


            var tg = new TapGestureRecognizer();
            tg.NumberOfTapsRequired = 1;
            tg.Tapped += (s, e) =>
            {
                // 必须要含有一个 Tap 动作, 才能启用 FrameTapLikeButtonBehavior
            };

            frame.GestureRecognizers.Add(tg);
            frame.Behaviors.Add(new Util.XamariN.Behaviors.FrameTapLikeButtonBehavior());

            StackLayout sl = new StackLayout();
            sl.HorizontalOptions = LayoutOptions.FillAndExpand;
            sl.Orientation = StackOrientation.Horizontal;


            leftImage = new Image();
            leftImage.Margin = new Thickness(5, 0, 0, 0);
            leftImage.WidthRequest = -1; // 默认根据图片大小
            leftImage.HorizontalOptions = LayoutOptions.EndAndExpand;


            label = new Label();
            label.Margin = new Thickness(5, 5, 5, 5);
            label.FontAttributes = FontAttributes.Bold;
            label.HorizontalOptions = LayoutOptions.Center;
            label.VerticalOptions = LayoutOptions.Center;
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.VerticalTextAlignment = TextAlignment.Center;
            label.TextColor = Color.Black;


            rightImage = new Image();
            rightImage.Margin = new Thickness(0, 0, 5, 0);
            rightImage.WidthRequest = -1; // 默认根据图片大小
            rightImage.HorizontalOptions = LayoutOptions.StartAndExpand;


            sl.Children.Add(leftImage);
            sl.Children.Add(label);
            sl.Children.Add(rightImage);

            frame.Content = sl;
        }

        #region Text

        public static readonly BindableProperty TextProperty = BindableProperty.Create
        (
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(Btn),
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

            (bindable as Btn).label.Text = value;
        }

        #endregion

        #region FontSize

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create
        (
            propertyName: "FontSize",
            returnType: typeof(double),
            declaringType: typeof(Btn),
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

            return v > 0 ? true : false;
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            double value = (double)newValue;
            if ((double)oldValue == value)
            {
                return;
            }

            (bindable as Btn).label.FontSize = value;
        }

        #endregion

        #region TextColor

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create
        (
            propertyName: "TextColor",
            returnType: typeof(Color),
            declaringType: typeof(Btn),
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

            (bindable as Btn).label.TextColor = value;
        }

        #endregion

        #region FontFamily

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create
        (
            propertyName: "FontFamily",
            returnType: typeof(string),
            declaringType: typeof(Btn),
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

            (bindable as Btn).label.FontFamily = value;
        }

        #endregion

        #region FontAttributes

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create
        (
            propertyName: "FontAttributes",
            returnType: typeof(Xamarin.Forms.FontAttributes),
            declaringType: typeof(Btn),
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

            (bindable as Btn).label.FontAttributes = value;
        }

        #endregion

        #region TextDecorations

        public static readonly BindableProperty TextDecorationsProperty = BindableProperty.Create
        (
            propertyName: "TextDecorations",
            returnType: typeof(Xamarin.Forms.TextDecorations),
            declaringType: typeof(Btn),
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

            (bindable as Btn).label.TextDecorations = value;
        }

        #endregion

        #region Left Images

        public ImageSource LeftImageSource
        {
            get
            {
                return this.leftImage.Source;
            }
            set
            {
                this.leftImage.Source = value;
            }
        }

        public double LeftImageWidthRequest
        {
            get
            {
                return this.leftImage.Width;
            }
            set
            {
                this.leftImage.WidthRequest = value;
            }
        }

        public double LeftImageHeightRequest
        {
            get
            {
                return this.leftImage.Height;
            }
            set
            {
                this.leftImage.HeightRequest = value;
            }
        }

        public Thickness LeftImageMargin
        {
            get
            {
                return this.leftImage.Margin;
            }
            set
            {
                this.leftImage.Margin = value;
            }
        }


        #endregion

        #region Right Image

        public ImageSource RightImageSource
        {
            get
            {
                return this.rightImage.Source;
            }
            set
            {
                this.rightImage.Source = value;
            }
        }

        public double RightImageWidthRequest
        {
            get
            {
                return this.rightImage.Width;
            }
            set
            {
                this.rightImage.WidthRequest = value;
            }
        }

        public double RightImageHeightRequest
        {
            get
            {
                return this.rightImage.Height;
            }
            set
            {
                this.rightImage.HeightRequest = value;
            }
        }

        public Thickness RightImageMargin
        {
            get
            {
                return this.rightImage.Margin;
            }
            set
            {
                this.rightImage.Margin = value;
            }
        }

        #endregion

    }
}
