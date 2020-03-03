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
    /// V 1.0.0 2020-1-14 16:32:09
    /// 首次创建
    /// </summary>
    public class BindableMultiSelectGroupView : StackLayout
    {
        private static readonly object _NullObject_ = new object();

        List<BindableMultiSelect> radioButtons;

        public BindableMultiSelectGroupView()
        {
            initUI();
            radioButtons = new List<BindableMultiSelect>();
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
            declaringType: typeof(BindableMultiSelectGroupView),
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
            BindableMultiSelectGroupView group = bindable as BindableMultiSelectGroupView;

            group.radioButtons.Clear();
            group.Children.Clear(); // StackLayout

            if (newValue != null)
            {
                int radIndex = 0;
                foreach (var item in newValue)
                {
                    var rad = new BindableMultiSelect();
                    rad.Id = radIndex;
                    rad.BindingContext = item;

                    rad.CheckedChanged += group.OnCheckedChanged;

                    group.radioButtons.Add(rad);
                    group.Children.Add(rad); // StackLayout

                    radIndex++;
                }

                sSetGroupViewUIProperty(group);

                #region 设置默认选中项

                if (group.SelectedTexts != null)
                {
                    List<string> temp = JsonUtils.DeserializeObject<List<string>>(group.SelectedTexts.ToString());

                    group.radioButtons
                        .Where(i => temp.Contains(i.Text))
                        .ToList()
                        .ForEach(i => i.IsChecked = true);
                }
                else if (group.SelectedNos != null)
                {
                    List<int> noList = null;
                    try
                    {
                        noList = JsonUtils.DeserializeObject<List<int>>(group.SelectedNos.ToString());
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"转换{ex.GetFullInfo()}");
                        System.Diagnostics.Debugger.Break();
                    }

                    foreach (int no in noList)
                    {
                        if (no > group.radioButtons.Count)
                        {
                            string msg = $"{0}";
                            System.Diagnostics.Debug.WriteLine(msg);

                            System.Diagnostics.Debugger.Break();
                        }
                        else
                        {
                            int index = no - 1;
                            group.radioButtons[index].IsChecked = true;
                        }
                    }
                }

                #endregion
            }
        }

        private static void sSetGroupViewUIProperty(BindableMultiSelectGroupView view)
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

                if (view.CheckBoxColor != Color.Transparent)
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
            if (radioButtons.Any(i => i.IsChecked) == false) // 一个都没有选择
            {
                SetValue(SelectedItemsProperty, null);
                SetValue(SelectedIndexesProperty, null);
                SetValue(SelectedTextsProperty, null);
                SetValue(SelectedNosProperty, null);
            }
            else // 有选择任何一个
            {
                var selectedItems = radioButtons.Where(i => i.IsChecked == true).ToArray();

                SetValue(SelectedItemsProperty, selectedItems.Select(i => i.BindingContext).ToArray());
                SetValue(SelectedIndexesProperty, selectedItems.Select(i => i.Id).ToArray());
                SetValue(SelectedTextsProperty, selectedItems.Select(i => i.Text).ToArray());
                SetValue(SelectedNosProperty, selectedItems.Select(i => (i.Id + 1).ToString()).ToArray());
            }
        }

        #region SelectedItem

        public static BindableProperty SelectedItemsProperty = BindableProperty.Create
        (
            propertyName: "SelectedItems"
            , returnType: typeof(object)
            , declaringType: typeof(BindableMultiSelectGroupView)
        // , propertyChanged: selectedItemsPropertyChanged
        );

        public object SelectedItems
        {
            get { return GetValue(SelectedItemsProperty); }
            set { SetValue(SelectedItemsProperty, value); }
        }

        //private static void selectedItemsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    System.Diagnostics.Debug.WriteLine($"newValue: {Util.JsonUtils.SerializeObject(newValue)}");


        //    var target = bindable as BindableMultiSelectGroupView;
        //    System.Diagnostics.Debug.WriteLine($"GetItems: {Util.JsonUtils.SerializeObject(target.SelectedItems)}");

        //    System.Diagnostics.Debugger.Break();
        //}

        #endregion

        #region SelectedText

        public static BindableProperty SelectedTextsProperty = BindableProperty.Create
        (
            propertyName: "SelectedTexts",
            returnType: typeof(object),
            declaringType: typeof(BindableMultiSelectGroupView),
            defaultValue: null,
            propertyChanged: selectedTextsPropertyChanged
        );

        public object SelectedTexts
        {
            get { return GetValue(SelectedTextsProperty); }
            set { SetValue(SelectedTextsProperty, value); }
        }

        private static void selectedTextsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView group = bindable as BindableMultiSelectGroupView;

            // 处理首次来自XAML的赋值
            if (oldValue == null && (newValue is string))
            {
                if (group.radioButtons != null && group.radioButtons.Count > 0)
                {
                    List<string> temp = JsonUtils.DeserializeObject<List<string>>(group.SelectedTexts.ToString());

                    group.radioButtons
                        .Where(i => temp.Contains(i.Text))
                        .ToList()
                        .ForEach(i => i.IsChecked = true);
                }
            }
        }

        #endregion

        #region SelectedIndexes

        public static BindableProperty SelectedIndexesProperty = BindableProperty.Create
        (
            propertyName: "SelectedIndexes"
            , returnType: typeof(IEnumerable<int>)
            , declaringType: typeof(BindableMultiSelectGroupView)
            , defaultValue: null
        );

        public object SelectedIndexes
        {
            get { return GetValue(SelectedIndexesProperty); }
            set { SetValue(SelectedIndexesProperty, value); }
        }

        //private static void selectedIndexPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    BindableMultiSelectGroupView group = bindable as BindableMultiSelectGroupView;

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

        #region SelectedNos

        public static BindableProperty SelectedNosProperty = BindableProperty.Create
        (
            propertyName: "SelectedNos",
            returnType: typeof(object),
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: selectedNosPropertyChanged
        );

        public object SelectedNos
        {
            get { return GetValue(SelectedNosProperty); }
            set { SetValue(SelectedNosProperty, value); }
        }

        private static void selectedNosPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView group = bindable as BindableMultiSelectGroupView;

            // 处理首次来自XAML的赋值
            if (oldValue == null && newValue is string)
            {
                string temp = newValue as string;
                try
                {
                    List<int> noList = Util.JsonUtils.DeserializeObject<List<int>>(temp);
                    if (group.radioButtons != null && group.radioButtons.Count > 0)
                    {
                        foreach (int no in noList)
                        {
                            if (no > group.radioButtons.Count)
                            {
                                string msg = $"{0}";
                                System.Diagnostics.Debug.WriteLine(msg);

                                System.Diagnostics.Debugger.Break();
                            }
                            else
                            {
                                var index = no - 1;
                                group.radioButtons[index].IsChecked = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"转换{ex.GetFullInfo()}");
                    System.Diagnostics.Debugger.Break();
                }
            }
        }

        #endregion

        #region DisplayPath

        public static BindableProperty DisplayPathProperty = BindableProperty.Create
        (
            propertyName: "DisplayPath",
            returnType: typeof(string),
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: displayPathChanged
        );

        public string DisplayPath
        {
            get { return (string)GetValue(DisplayPathProperty); }
            set { SetValue(DisplayPathProperty, value); }
        }

        private static void displayPathChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;

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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: fontSizePropertyChanged
        );

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        private static void fontSizePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;

            if (double.TryParse(newValue.ToString(), out double tmp))
            {
                foreach (BindableMultiSelect btn in target.radioButtons)
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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: fontAttributesPropertyChanged
        );

        public string FontAttributes
        {
            get { return (string)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        private static void fontAttributesPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;

            foreach (BindableMultiSelect btn in target.radioButtons)
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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: textColorPropertyChanged
        );

        public Xamarin.Forms.Color TextColor
        {
            get { return (Xamarin.Forms.Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        private static void textColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;
            foreach (BindableMultiSelect btn in target.radioButtons)
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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: CheckBoxColorPropertyChanged
        );

        public Xamarin.Forms.Color CheckBoxColor
        {
            get { return (Xamarin.Forms.Color)GetValue(CheckBoxColorProperty); }
            set { SetValue(CheckBoxColorProperty, value); }
        }

        private static void CheckBoxColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;
            foreach (BindableMultiSelect btn in target.radioButtons)
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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: checkBoxMarginPropertyPropertyChanged
        );

        public string CheckBoxMargin
        {
            get { return (string)GetValue(CheckBoxMarginProperty); }
            set { SetValue(CheckBoxMarginProperty, value); }
        }

        private static void checkBoxMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;
            foreach (BindableMultiSelect btn in target.radioButtons)
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
            declaringType: typeof(BindableMultiSelectGroupView),
            propertyChanged: labelMarginPropertyPropertyChanged
        );

        public string LabelMargin
        {
            get { return (string)GetValue(LabelMarginProperty); }
            set { SetValue(LabelMarginProperty, value); }
        }

        private static void labelMarginPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            BindableMultiSelectGroupView target = bindable as BindableMultiSelectGroupView;
            foreach (BindableMultiSelect btn in target.radioButtons)
            {
                btn.LabelMargin = newValue.ToString();
            }
        }

        #endregion
    }
}

