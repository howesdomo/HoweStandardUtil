using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.0 2020-1-14 16:32:09
    /// 首次创建
    /// </summary>
    public class BindableMultiSelect : ContentView
    {
        /// <summary>
        /// The checked changed event.
        /// </summary>
        public EventHandler<EventArgs<bool>> CheckedChanged;

        private bool _IsChecked;
        public bool IsChecked
        {
            get { return _IsChecked; }
            set
            {
                _IsChecked = value;
                this.OnPropertyChanged("IsChecked");
            }
        }

        private string _TextProperty;
        public string TextProperty
        {
            get { return _TextProperty; }
            set
            {
                _TextProperty = value;
                this.OnPropertyChanged("TextProperty");
            }
        }

        public new int Id { get; set; }

        CheckBox mckb { get; set; }
        Label mlbl { get; set; }

        public BindableMultiSelect()
        {
            initUI();
            initEvent();
        }

        private void initUI()
        {
            StackLayout sl = new StackLayout();

            sl.Orientation = StackOrientation.Horizontal;

            mckb = new CheckBox();
            mckb.VerticalOptions = LayoutOptions.StartAndExpand;
            sl.Children.Add(mckb);

            mlbl = new Label();
            mlbl.Margin = new Thickness(left: 0, top: 0, right: 0, bottom: 0);
            mlbl.VerticalTextAlignment = TextAlignment.Center;
            mlbl.HorizontalOptions = LayoutOptions.FillAndExpand;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                this.IsChecked = !this.IsChecked;
            };

            mlbl.GestureRecognizers.Add(tapGestureRecognizer);

            sl.Children.Add(mlbl);
            this.Content = sl;
        }

        private void initEvent()
        {
            this.BindingContextChanged += BindingContextChangedHandled;

            this.mckb.CheckedChanged += checkedChanged;

            Binding b_IsChecked = new Binding("IsChecked");
            b_IsChecked.Source = this;
            b_IsChecked.Mode = BindingMode.TwoWay;

            this.mckb.SetBinding(CheckBox.IsCheckedProperty, b_IsChecked);
        }

        private void checkedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.CheckedChanged != null)
            {
                this.CheckedChanged.Invoke(this, new EventArgs<bool>(e.Value));
            }
        }

        private void BindingContextChangedHandled(object sender, EventArgs e)
        {
            mlbl.Text = this.BindingContext.ToString();
        }

        public void SetTextBinding(string name)
        {
            Binding b_Text = new Binding(name);
            b_Text.Source = this.BindingContext;
            b_Text.Mode = BindingMode.TwoWay;

            this.mlbl.SetBinding(Label.TextProperty, b_Text);
        }

        public string Text
        {
            get { return this.mlbl.Text; }
        }

        // UI

        #region FontSizeProperty

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create
        (
            propertyName: "FontSize",
            returnType: typeof(double),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: fontSizePropertyChanged
        );

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;

            if (target.mlbl.FontSize.ToString() == newValue.ToString())
            {
                return;
            }

            if (double.TryParse(newValue.ToString(), out double tmp))
            {
                target.mlbl.FontSize = tmp;
            }
        }

        #endregion

        #region FontAttributesProperty

        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create
        (
            propertyName: "FontAttributes",
            returnType: typeof(string),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: fontAttributesPropertyChanged
        );

        public string FontAttributes
        {
            get { return (string)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        private static void fontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;
            if (target.mlbl.FontAttributes.ToString() == newValue.ToString())
            {
                return;
            }

            target.mlbl.FontAttributes = (FontAttributes)new Converters.FontAttributesConverter().Convert(newValue, null, null, null);
        }

        #endregion

        #region TextColor

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create
        (
            propertyName: "TextColor",
            returnType: typeof(Xamarin.Forms.Color),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: textColorPropertyChanged
        );

        public Xamarin.Forms.Color TextColor
        {
            get { return (Xamarin.Forms.Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void textColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;
            if (target.mlbl.TextColor == (Xamarin.Forms.Color)newValue)
            {
                return;
            }

            target.mlbl.TextColor = (Xamarin.Forms.Color)newValue;
        }

        #endregion

        #region CheckBoxColor

        public static readonly BindableProperty CheckBoxColorProperty = BindableProperty.Create
        (
            propertyName: "CheckBoxColor",
            returnType: typeof(Xamarin.Forms.Color),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: CheckBoxColorPropertyChanged
        );

        public Xamarin.Forms.Color CheckBoxColor
        {
            get { return (Xamarin.Forms.Color)GetValue(CheckBoxColorProperty); }
            set { SetValue(CheckBoxColorProperty, value); }
        }

        private static void CheckBoxColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;
            if (target.mckb.Color == (Xamarin.Forms.Color)newValue)
            {
                return;
            }

            target.mckb.Color = (Xamarin.Forms.Color)newValue;
        }

        #endregion

        #region CheckBoxMargin

        public static readonly BindableProperty CheckBoxMarginProperty = BindableProperty.Create
        (
            propertyName: "CheckBoxMargin",
            returnType: typeof(string),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: checkBoxMarginPropertyPropertyChanged
        );

        public string CheckBoxMargin
        {
            get { return (string)GetValue(CheckBoxMarginProperty); }
            set { SetValue(CheckBoxMarginProperty, value); }
        }

        private static void checkBoxMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;
            Thickness margin = Common.ThicknessUtils.CalcThickness(newValue);
            if (target.mckb.Margin != margin)
            {
                target.mckb.Margin = margin;
            }
        }

        #endregion

        #region LabelMargin

        public static readonly BindableProperty LabelMarginProperty = BindableProperty.Create
        (
            propertyName: "LabelMargin",
            returnType: typeof(string),
            declaringType: typeof(BindableMultiSelect),
            propertyChanged: labelMarginPropertyPropertyChanged
        );

        public string LabelMargin
        {
            get { return (string)GetValue(LabelMarginProperty); }
            set { SetValue(LabelMarginProperty, value); }
        }

        private static void labelMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelect target = bindable as BindableMultiSelect;
            Thickness margin = Common.ThicknessUtils.CalcThickness(newValue);
            if (target.mlbl.Margin != margin)
            {
                target.mlbl.Margin = margin;
            }
        }

        #endregion
    }
}
