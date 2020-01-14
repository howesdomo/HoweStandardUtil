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

        #endregion

        public static BindableProperty SelectedItemProperty = BindableProperty.Create
        (
            propertyName: "SelectedItem",
            returnType: typeof(object),
            declaringType: typeof(BindableRadioGroupView)
        );

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static BindableProperty SelectedIndexProperty = BindableProperty.Create
        (
            propertyName: "SelectedIndex",
            returnType: typeof(int),
            declaringType: typeof(BindableRadioGroupView)
        );

        public object SelectedIndex
        {
            get { return GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
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
            }
        }

        private void OnCheckedChanged(object sender, EventArgs<bool> e)
        {
            if (e.Value == false)
            {
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
                }
            }
        }

    }
}

