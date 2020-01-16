using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.1 2020-1-15 17:43:25
    /// 修复返回类型 FontAttributes 
    /// 
    /// V 1.0.0 2020-1-14 16:32:09
    /// 首次创建
    /// </summary>
    public class AutoRelateRadioButton : ContentView
    {
        public List<AutoRelateRadioButton> GroupRelationList { get; set; }

        private bool _IsChecked;
        public bool IsChecked
        {
            get { return _IsChecked; }
            set
            {
                if (_IsChecked == value)
                {
                    return;
                }
                else
                {
                    setIsCheck(value);
                    this.OnPropertyChanged("IsChecked");
                }
            }
        }

        void setIsCheck(bool setValue)
        {
            if (setValue == false)
            {
                _IsChecked = false;
                return;
            }
            else
            {
                foreach (AutoRelateRadioButton item in GroupRelationList)
                {
                    if (item == this)
                    {
                        _IsChecked = true;
                        this.SelectedValue = item.Text;
                    }
                    else
                    {
                        item.IsChecked = false;
                    }
                }
            }
        }

        CheckBox mckb { get; set; }

        Label mlbl { get; set; }

        public AutoRelateRadioButton()
        {
            initUI();
            initEvent();
        }

        private void initUI()
        {
            StackLayout sl = new StackLayout();

            sl.Orientation = StackOrientation.Horizontal;

            mckb = new CheckBox();
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
            Binding binding = new Binding("IsChecked");
            binding.Source = this;
            binding.Mode = BindingMode.TwoWay;

            this.mckb.SetBinding(CheckBox.IsCheckedProperty, binding);
        }

        #region GroupIDProperty

        public static readonly BindableProperty GroupIDProperty = BindableProperty.Create
        (
            propertyName: "GroupID",
            returnType: typeof(string),
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: groupIDPropertyChanged
        );

        public string GroupID
        {
            get { return (string)GetValue(GroupIDProperty); }
            set { SetValue(GroupIDProperty, value); }
        }

        private static void groupIDPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;

            if (target.GroupRelationList != null)
            {
                throw new Exception("已经设置了GroupID, 但是又被设置成其他值了");
            }
            string groupID = newValue.ToString();
            AutoRelateRadioButton.GroupByID(groupID, target);
        }

        #endregion

        #region TextProperty

        public static readonly BindableProperty TextProperty = BindableProperty.Create
        (
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: textPropertyChanged
        );

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        private static void textPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;

            if (target.mlbl.Text == newValue.ToString())
            {
                return;
            }

            target.mlbl.Text = newValue.ToString();
        }

        #endregion

        #region FontSizeProperty

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create
        (
            propertyName: "FontSize",
            returnType: typeof(double),
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: fontSizePropertyChanged
        );

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;

            if (target.mlbl.FontSize.ToString() == newValue.ToString())
            {
                return;
            }

            double tmp = 0;

            if (double.TryParse(newValue.ToString(), out tmp))
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
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: fontAttributesPropertyChanged
        );

        public string FontAttributes
        {
            get { return (string)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        private static void fontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;
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
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: textColorPropertyChanged
        );

        public string TextColor
        {
            get { return (string)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void textColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;
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
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: CheckBoxColorPropertyChanged
        );

        public string CheckBoxColor
        {
            get { return (string)GetValue(CheckBoxColorProperty); }
            set { SetValue(CheckBoxColorProperty, value); }
        }

        private static void CheckBoxColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;
            if (target.mckb.Color == (Xamarin.Forms.Color)newValue)
            {
                return;
            }

            target.mckb.Color = (Xamarin.Forms.Color)newValue;
        }

        #endregion

        #region SelectedValue

        public static readonly BindableProperty SelectedValueProperty = BindableProperty.Create
        (
            propertyName: "SelectedValue",
            returnType: typeof(string),
            declaringType: typeof(AutoRelateRadioButton),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: selectedValuePropertyChanged
        );

        public string SelectedValue
        {
            get { return (string)GetValue(SelectedValueProperty); }
            set { SetValue(SelectedValueProperty, value); }
        }

        private static void selectedValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;

            if (newValue == null)
            {
                return;
            }
            string newValueStr = newValue.ToString();
            if (oldValue != null && oldValue.ToString() == newValueStr)
            {
                return;
            }

            if (target.GroupRelationList != null)
            {
                foreach (AutoRelateRadioButton item in target.GroupRelationList)
                {
                    if (item.Text == newValueStr)
                    {
                        item.IsChecked = true;
                    }
                    else
                    {
                        item.IsChecked = false;
                    }
                }
            }
        }

        #endregion

        #region CheckBoxMargin

        public static readonly BindableProperty CheckBoxMarginProperty = BindableProperty.Create
        (
            propertyName: "CheckBoxMargin",
            returnType: typeof(string),
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: checkBoxMarginPropertyPropertyChanged
        );

        public string CheckBoxMargin
        {
            get { return (string)GetValue(CheckBoxMarginProperty); }
            set { SetValue(CheckBoxMarginProperty, value); }
        }

        private static void checkBoxMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;
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
            declaringType: typeof(AutoRelateRadioButton),
            propertyChanged: labelMarginPropertyPropertyChanged
        );

        public string LabelMargin
        {
            get { return (string)GetValue(LabelMarginProperty); }
            set { SetValue(LabelMarginProperty, value); }
        }

        private static void labelMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            AutoRelateRadioButton target = bindable as AutoRelateRadioButton;
            Thickness margin = Common.ThicknessUtils.CalcThickness(newValue);
            if (target.mlbl.Margin != margin)
            {
                target.mlbl.Margin = margin;
            }
        }

        #endregion

        #region 配对RadioButtonGroup (静态方法)

        private static Dictionary<string, List<AutoRelateRadioButton>> sDict = new Dictionary<string, List<AutoRelateRadioButton>>();

        /// <summary>
        /// 每次调用 UIJsonFileUtils.ReadJsonFile 方法时, 请务必要调用本方法来清空关联
        /// </summary>
        public static void DictClear()
        {
            if (sDict != null)
            {
                sDict.Clear();
            }
            else
            {
                sDict = new Dictionary<string, List<AutoRelateRadioButton>>();
            }
        }

        public static void GroupByID(string key, AutoRelateRadioButton radioButton)
        {
            List<AutoRelateRadioButton> matchQuery = null;
            if (sDict.TryGetValue(key, out matchQuery) == false)
            {
                matchQuery = new List<AutoRelateRadioButton>();
                sDict.TryAdd(key, matchQuery);
            }

            matchQuery.Add(radioButton);
            radioButton.GroupRelationList = matchQuery;
        }

        #endregion
    }
}