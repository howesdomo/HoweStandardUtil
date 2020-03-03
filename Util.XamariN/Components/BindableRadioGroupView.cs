using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.1 2020-1-16 09:27:36
    /// 1 增加 SelectedNo 与 SelectedText 属性 (赋值用)
    /// 2 增加 UI 属性 (绑定用)
    /// 
    /// V 1.0.0 2020-1-14 16:32:09
    /// 首次创建
    /// </summary>
    public class BindableRadioGroupView : StackLayout
    {
        List<BindableRadioButton> radioButtons;

        public BindableRadioGroupView()
        {
            initUI();
            radioButtons = new List<BindableRadioButton>();
        }

        private void initUI()
        {
            this.Spacing = 0;
        }

        #region ItemsSource

        public static BindableProperty ItemsSourceProperty = BindableProperty.Create
        (
            propertyName: "ItemsSource",
            returnType: typeof(IEnumerable),
            declaringType: typeof(BindableRadioGroupView),
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: ItemsSourcePropertyChanged
        );

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        private static void ItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ItemsSourcePropertyChanged(bindable, oldValue as IEnumerable, newValue as IEnumerable);
        }

        private static void ItemsSourcePropertyChanged(BindableObject bindable, IEnumerable oldValue, IEnumerable newValue)
        {
            BindableRadioGroupView group = bindable as BindableRadioGroupView;

            group.radioButtons.Clear();
            group.Children.Clear(); // StackLayout

            if (newValue != null)
            {
                int radIndex = 0;
                foreach (var item in newValue)
                {
                    var rad = new BindableRadioButton();
                    rad.Id = radIndex;
                    rad.BindingContext = item;
                    
                    rad.CheckedChanged += group.OnCheckedChanged;

                    group.radioButtons.Add(rad);
                    group.Children.Add(rad); // StackLayout

                    radIndex++;
                }

                sSetGroupViewUIProperty(group);

                #region 设置默认选中项

                if (group.SelectedText != null)
                {
                    var match = group.radioButtons.FirstOrDefault(i => i.Text == group.SelectedText.ToString());
                    if (match != null)
                    {
                        match.IsChecked = true;
                    }
                }
                else if (int.TryParse(group.SelectedNo.ToString(), out int no) && no > 0)
                {
                    if (no >= 1)
                    {
                        int index = no - 1;
                        group.radioButtons[index].IsChecked = true;
                    }
                }

                #endregion
            }
        }

        private static void sSetGroupViewUIProperty(BindableRadioGroupView view)
        {
            if (view.radioButtons == null || view.radioButtons.Count <= 0)
            {
                return;
            }

            foreach (var rad in view.radioButtons)
            {
                if (view.DisplayPath.IsNullOrWhiteSpace() == false)
                {
                    rad.SetTextBinding(view.DisplayPath);
                }

                if (view.CheckBoxColor != Xamarin.Forms.Color.Transparent)
                {
                    rad.CheckBoxColor = view.CheckBoxColor;
                }

                if (view.TextColor != Xamarin.Forms.Color.Transparent)
                {
                    rad.TextColor = view.TextColor;
                }

                if (view.CheckBoxMargin.IsNullOrWhiteSpace() == false)
                {
                    rad.CheckBoxMargin = view.CheckBoxMargin;
                }

                if (view.LabelMargin.IsNullOrWhiteSpace() == false)
                {
                    rad.LabelMargin = view.LabelMargin;
                }

                if (view.FontAttributes.IsNullOrWhiteSpace() == false)
                {
                    rad.FontAttributes = view.FontAttributes;
                }

                if (view.FontSize > 0)
                {
                    rad.FontSize = view.FontSize;
                }
            }
        }

        #endregion

        private void OnCheckedChanged(object sender, EventArgs<bool> e)
        {
            if (e.Value == false)
            {
                if (radioButtons.Any(i => i.IsChecked) == false)
                {
                    SetValue(SelectedItemProperty, null);
                    SetValue(SelectedIndexProperty, -1);
                    SetValue(SelectedTextProperty, string.Empty);
                    SetValue(SelectedNoProperty, "0");
                }
                return;
            }

            var selectedRad = sender as BindableRadioButton;

            foreach (var rad in radioButtons)
            {
                if (selectedRad.Id.Equals(rad.Id) == false)
                {
                    rad.IsChecked = false;
                }
                else
                {
                    var selectedItem = rad.BindingContext;
                    SetValue(SelectedItemProperty, selectedItem);

                    var selectedIndex = this.radioButtons.IndexOf(rad);
                    SetValue(SelectedIndexProperty, selectedIndex);

                    SetValue(SelectedTextProperty, rad.Text);

                    SetValue(SelectedNoProperty, (selectedIndex + 1).ToString());
                }
            }
        }

        #region SelectedItem

        public static BindableProperty SelectedItemProperty = BindableProperty.Create
        (
            propertyName: "SelectedItem"
            , returnType: typeof(object)
            , declaringType: typeof(BindableRadioGroupView)
            , defaultBindingMode: BindingMode.TwoWay
            , defaultValue: null
        // , propertyChanged: selectedItemPropertyChanged
        );

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        //private static void selectedItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    BindableRadioGroupView group = bindable as BindableRadioGroupView;

        //    if (oldValue == null && group.radioButtons != null)
        //    {
        //        foreach (BindableRadioButton item in group.radioButtons)
        //        {
        //            if (item.Text == newValue.ToString())
        //            {
        //                item.IsChecked = true;
        //                break;
        //            }
        //        }
        //    }
        //}

        #endregion

        #region SelectedText

        public static BindableProperty SelectedTextProperty = BindableProperty.Create
        (
            propertyName: "SelectedText",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: null,
            propertyChanged: selectedTextPropertyChanged
        );

        private static void selectedTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView group = bindable as BindableRadioGroupView;

            if (oldValue == null && group.radioButtons != null)
            {
                foreach (BindableRadioButton item in group.radioButtons)
                {
                    if (item.Text == newValue.ToString())
                    {
                        item.IsChecked = true;
                        break;
                    }
                }
            }
        }

        public object SelectedText
        {
            get { return GetValue(SelectedTextProperty); }
            set { SetValue(SelectedTextProperty, value); }
        }

        #endregion

        #region SelectedIndex

        public static BindableProperty SelectedIndexProperty = BindableProperty.Create
        (
            propertyName: "SelectedIndex"
            , returnType: typeof(int)
            , declaringType: typeof(BindableRadioGroupView)
            , defaultBindingMode: BindingMode.TwoWay
            , defaultValue: -1
        // , propertyChanged: selectedIndexPropertyChanged
        );

        public object SelectedIndex
        {
            get { return GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        //private static void selectedIndexPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    BindableRadioGroupView group = bindable as BindableRadioGroupView;

        //    if (oldValue == null && group.radioButtons != null)
        //    {
        //        int index = 0;
        //        if (int.TryParse(newValue.ToString(), out index))
        //        {
        //            group.radioButtons[index].IsChecked = true;
        //        }
        //    }
        //}

        #endregion

        #region SelectedNo

        public static BindableProperty SelectedNoProperty = BindableProperty.Create
        (
            propertyName: "SelectedNo",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: "0",
            propertyChanged: selectedNoPropertyChanged
        );

        public object SelectedNo
        {
            get { return GetValue(SelectedNoProperty); }
            set { SetValue(SelectedNoProperty, value); }
        }

        private static void selectedNoPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView group = bindable as BindableRadioGroupView;

            if (oldValue == null && group.radioButtons != null)
            {
                int no;
                if (int.TryParse(newValue.ToString(), out no) && no > 0)
                {
                    int index = no - 1;
                    group.radioButtons[index].IsChecked = true;
                }
            }
        }

        #endregion

        #region DisplayPath

        public static BindableProperty DisplayPathProperty = BindableProperty.Create
        (
            propertyName: "DisplayPath",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            propertyChanged: displayPathChanged
        );

        public string DisplayPath
        {
            get { return (string)GetValue(DisplayPathProperty); }
            set { SetValue(DisplayPathProperty, value); }
        }

        private static void displayPathChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;

            if (target.radioButtons == null)
            {
                return;
            }

            foreach (var item in target.radioButtons)
            {
                string displayPath = newValue.ToString();
                item.SetTextBinding(displayPath);
            }
        }

        #endregion

        // UI
        #region FontSizeProperty

        public static BindableProperty FontSizeProperty = BindableProperty.Create
        (
            propertyName: "FontSize",
            returnType: typeof(double),
            declaringType: typeof(BindableRadioGroupView),
            propertyChanged: fontSizePropertyChanged
        );

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;

            if (double.TryParse(newValue.ToString(), out double tmp))
            {
                foreach (BindableRadioButton btn in target.radioButtons)
                {
                    btn.FontSize = tmp;
                }
            }
        }

        #endregion

        #region FontAttributesProperty

        public static BindableProperty FontAttributesProperty = BindableProperty.Create
        (
            propertyName: "FontAttributes",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            propertyChanged: fontAttributesPropertyChanged
        );

        public string FontAttributes
        {
            get { return (string)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        private static void fontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;

            foreach (BindableRadioButton btn in target.radioButtons)
            {
                btn.FontAttributes = newValue.ToString();
            }
        }

        #endregion

        #region TextColor

        public static BindableProperty TextColorProperty = BindableProperty.Create
        (
            propertyName: "TextColor",
            returnType: typeof(Xamarin.Forms.Color),
            declaringType: typeof(BindableRadioGroupView),
            defaultValue: Xamarin.Forms.Color.Black,
            propertyChanged: textColorPropertyChanged
        );

        public Xamarin.Forms.Color TextColor
        {
            get { return (Xamarin.Forms.Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void textColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;
            foreach (BindableRadioButton btn in target.radioButtons)
            {
                btn.TextColor = (Xamarin.Forms.Color)newValue;
            }
        }

        #endregion

        #region CheckBoxColor

        public static BindableProperty CheckBoxColorProperty = BindableProperty.Create
        (
            propertyName: "CheckBoxColor",
            returnType: typeof(Xamarin.Forms.Color),
            declaringType: typeof(BindableRadioGroupView),
            defaultValue: Xamarin.Forms.Color.Red,
            propertyChanged: CheckBoxColorPropertyChanged
        );

        public Xamarin.Forms.Color CheckBoxColor
        {
            get { return (Xamarin.Forms.Color)GetValue(CheckBoxColorProperty); }
            set { SetValue(CheckBoxColorProperty, value); }
        }

        private static void CheckBoxColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;
            foreach (BindableRadioButton btn in target.radioButtons)
            {
                btn.CheckBoxColor = (Xamarin.Forms.Color)newValue;
            }
        }

        #endregion        

        #region CheckBoxMargin

        public static BindableProperty CheckBoxMarginProperty = BindableProperty.Create
        (
            propertyName: "CheckBoxMargin",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            propertyChanged: checkBoxMarginPropertyPropertyChanged
        );

        public string CheckBoxMargin
        {
            get { return (string)GetValue(CheckBoxMarginProperty); }
            set { SetValue(CheckBoxMarginProperty, value); }
        }

        private static void checkBoxMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;
            foreach (BindableRadioButton btn in target.radioButtons)
            {
                btn.CheckBoxMargin = newValue.ToString();
            }
        }

        #endregion

        #region LabelMargin

        public static BindableProperty LabelMarginProperty = BindableProperty.Create
        (
            propertyName: "LabelMargin",
            returnType: typeof(string),
            declaringType: typeof(BindableRadioGroupView),
            propertyChanged: labelMarginPropertyPropertyChanged
        );

        public string LabelMargin
        {
            get { return (string)GetValue(LabelMarginProperty); }
            set { SetValue(LabelMarginProperty, value); }
        }

        private static void labelMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableRadioGroupView target = bindable as BindableRadioGroupView;
            foreach (BindableRadioButton btn in target.radioButtons)
            {
                btn.LabelMargin = newValue.ToString();
            }
        }

        #endregion
    }
}

