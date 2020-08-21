using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Util.XamariN.Components
{
    /// <summary>
    /// V 1.0.1 - 2020-08-20 16:44:12
    /// 优化 Text 属性, 改为绑定属性 ( 双向绑定 )
    /// 
    /// V 1.0.0 - 2020-08-09 09:49:52
    /// Xamarin.Forms 原生 SearchBar有一个缺点输入框没有内容时不会触发 SearchCommand, 
    /// 故自制的控件 FilterBar 修复输入框没有内容时不会触发 SearchCommand 的问题
    /// </summary>
    public class FilterBar : Frame
    {
        Image imgFilter { get; set; }

        Entry txtFilter { get; set; }

        Image imgClear { get; set; }

        #region SearchCommand

        public static readonly BindableProperty SearchCommandProperty = BindableProperty.Create
        (
            propertyName: "SearchCommand",
            returnType: typeof(ICommand),
            declaringType: typeof(FilterBar),
            defaultValue: null
        );

        public ICommand SearchCommand
        {
            get
            {
                return (ICommand)base.GetValue(SearchCommandProperty);
            }
            set
            {
                base.SetValue(SearchCommandProperty, value);
            }
        }

        #endregion

        #region [弃用] SearchCommandParameter

        //public static readonly BindableProperty SearchCommandParameterProperty = BindableProperty.Create
        //(
        //    propertyName: "SearchCommandParameter",
        //    returnType: typeof(object),
        //    declaringType: typeof(FilterBar),
        //    defaultValue: null
        //);

        //public object SearchCommandParameter
        //{
        //    get
        //    {

        //        return base.GetValue(SearchCommandParameterProperty);
        //    }
        //    set
        //    {
        //        base.SetValue(SearchCommandParameterProperty, value);
        //    }
        //}

        #endregion

        #region IsTextChangeExecute

        public static readonly BindableProperty IsTextChangeExecuteProperty = BindableProperty.Create
        (
            propertyName: "IsTextChangeExecute",
            returnType: typeof(bool),
            declaringType: typeof(FilterBar),
            defaultValue: false
        );

        public bool IsTextChangeExecute
        {
            get
            {
                return (bool)base.GetValue(IsTextChangeExecuteProperty);
            }
            set
            {
                base.SetValue(IsTextChangeExecuteProperty, value);
            }
        }

        #endregion

        #region Text 绑定属性

        public static readonly BindableProperty TextProperty = BindableProperty.Create
        (
            propertyName: "Text",
            returnType: typeof(string),
            declaringType: typeof(FilterBar),
            defaultValue: string.Empty,
            validateValue: text_IsValidValue,
            // propertyChanged: textPropertyChanged,
            defaultBindingMode: BindingMode.TwoWay
        );

        public string Text
        {
            get
            {
                return (string)base.GetValue(TextProperty);
            }
            set
            {
                base.SetValue(TextProperty, value);
            }
        }


        private static bool text_IsValidValue(BindableObject bindable, object value)
        {
            if (value == null || value is string)
            {
                // 对 txtFilter.Text 赋值改在 text_IsValidValue 中进行
                if (value == null) 
                {
                    (bindable as FilterBar).txtFilter.Text = string.Empty;
                }
                else 
                {
                    (bindable as FilterBar).txtFilter.Text = value as string;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        //// 第一次赋值时能进入 textPropertyChanged, 但第二次时却无法进入, 未能知道原因, 
        //// 故暂时不在 textPropertyChanged 中对 txtFilter.Text 进行赋值
        //private static void textPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    if (newValue == null)
        //    {
        //        return;
        //    }

        //    string value = (string)newValue;
        //    if ((string)oldValue == value)
        //    {
        //        return;
        //    }

        //    (bindable as FilterBar).txtFilter.Text = value;
        //}


        #endregion

        //#region [弃用]Text // 需要用到双向绑定, 直接赋值的方法不够灵活

        //public string Text
        //{
        //    get
        //    {
        //        return txtFilter.Text;
        //    }
        //    set
        //    {
        //        txtFilter.Text = value;
        //    }
        //}

        //#endregion

        #region TextColorProperty

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create
        (
            propertyName: "TextColor",
            returnType: typeof(Color),
            declaringType: typeof(FilterBar),
            defaultValue: null,
            validateValue: textColor_IsValidValue,
            propertyChanged: textColorPropertyChanged
        );

        public Color TextColor
        {
            get
            {
                return (Color)base.GetValue(TextColorProperty);
            }
            set
            {
                base.SetValue(TextColorProperty, value);
            }
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

            (bindable as FilterBar).txtFilter.TextColor = value;
        }

        #endregion

        #region Placeholder

        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create
        (
            propertyName: "Placeholder",
            returnType: typeof(string),
            declaringType: typeof(FilterBar),
            defaultValue: string.Empty,
            validateValue: placeholder_IsValidValue,
            propertyChanged: placeholderPropertyChanged
        );

        public string Placeholder
        {
            get
            {
                return (string)base.GetValue(PlaceholderProperty);
            }
            set
            {
                base.SetValue(PlaceholderProperty, value);
            }
        }

        private static bool placeholder_IsValidValue(BindableObject view, object value)
        {
            return value is string;
        }

        private static void placeholderPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            string value = (string)newValue;
            if ((string)oldValue == value)
            {
                return;
            }

            (bindable as FilterBar).txtFilter.Placeholder = value;
        }


        #endregion

        #region PlaceholderColorProperty

        public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create
        (
            propertyName: "PlaceholderColor",
            returnType: typeof(Color),
            declaringType: typeof(FilterBar),
            defaultValue: null,
            validateValue: placeholderColor_IsValidValue,
            propertyChanged: placeholderColorPropertyChanged
        );

        public Color PlaceholderColor
        {
            get
            {
                return (Color)base.GetValue(PlaceholderColorProperty);
            }
            set
            {
                base.SetValue(PlaceholderColorProperty, value);
            }
        }


        private static bool placeholderColor_IsValidValue(BindableObject view, object value)
        {
            return value is Color;
        }

        private static void placeholderColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            Color value = (Color)newValue;
            if ((Color)oldValue == value)
            {
                return;
            }

            (bindable as FilterBar).txtFilter.PlaceholderColor = value;
        }

        #endregion

        public FilterBar()
        {
            initUI();
            initEvent();
        }

        public void initUI()
        {
            Padding = new Thickness(20, 0, 20, 0);
            this.BackgroundColor = Color.Transparent;

            Grid g = new Grid();
            g.HorizontalOptions = LayoutOptions.Fill;
            g.VerticalOptions = LayoutOptions.Fill;

            g.RowDefinitions = new RowDefinitionCollection()
            {
                new RowDefinition(){ Height = new GridLength(1, GridUnitType.Auto) }
            };

            g.ColumnDefinitions = new ColumnDefinitionCollection();
            g.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });
            g.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            g.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) });

            imgFilter = new Image();
            imgFilter.WidthRequest = 20;
            imgFilter.HeightRequest = 20;
            imgFilter.HorizontalOptions = LayoutOptions.Center;
            imgFilter.VerticalOptions = LayoutOptions.Center;
            imgFilter.Source = new FontImageSource()
            {
                FontFamily = "FontAwesome",
                Glyph = Util_Font.FontAwesomeIcons.Filter,
                Color = Color.Gray,
                Size = 30
            };
            Grid.SetColumn(imgFilter, 0);

            txtFilter = new Entry();
            txtFilter.VerticalOptions = LayoutOptions.EndAndExpand;
            Grid.SetColumn(txtFilter, 1);
            Grid.SetColumnSpan(txtFilter, 2);

            imgClear = new Image();
            imgClear.WidthRequest = 24;
            imgClear.HeightRequest = 24;
            imgClear.HorizontalOptions = LayoutOptions.Center;
            imgClear.VerticalOptions = LayoutOptions.Center;
            imgClear.Source = new FontImageSource()
            {
                FontFamily = "FontAwesome",
                Glyph = Util_Font.FontAwesomeIcons.Times,
                Color = Color.Red,
                Size = 30
            };
            imgClear.IsVisible = false;
            Grid.SetColumn(imgClear, 2);

            g.Children.Add(imgFilter);
            g.Children.Add(txtFilter);
            g.Children.Add(imgClear);

            this.Content = g;
        }

        public void initEvent()
        {
            txtFilter.TextChanged += txtFilter_TextChanged;
            txtFilter.Completed += txtFilter_Completed;

            imgFilter.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
                Command = new Command(() =>
                {
                    searchCommandExecute();
                    onSearch();
                })
            });

            imgClear.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                NumberOfTapsRequired = 1,
                Command = new Command(() =>
                {
                    txtFilter.Text = string.Empty;
                    this.imgClear.IsVisible = false;

                    if (IsTextChangeExecute == false) // 当前设置是手动执行, 故手动编写代码执行
                    {
                        searchCommandExecute(isEmptyQuery: true);
                        onSearch(isEmptyQuery: true);
                    }
                })
            });
        }


        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = (sender as Entry).Text;
            if (this.imgClear.IsVisible == false && string.IsNullOrEmpty(text) == false)
            {
                this.imgClear.IsVisible = true;
            }

            if (this.imgClear.IsVisible == true && string.IsNullOrEmpty(text) == true)
            {
                this.imgClear.IsVisible = false;
            }

            if (IsTextChangeExecute == true)
            {
                searchCommandExecute();
                onSearch();
            }
        }

        private void txtFilter_Completed(object sender, EventArgs e)
        {
            if (IsTextChangeExecute == false)
            {
                searchCommandExecute();
                onSearch();
            }
        }

        private void searchCommandExecute(bool? isEmptyQuery = null)
        {
            if (this.SearchCommand == null)
            {
                //string msg = "SearchCommand is null";
                //System.Diagnostics.Debug.WriteLine(msg);

                return;
            }

            if (isEmptyQuery.HasValue == true && isEmptyQuery.Value == true)
            {
                this.SearchCommand.Execute(string.Empty);
            }
            else
            {
                this.SearchCommand.Execute(this.txtFilter.Text);
            }
        }

        public event EventHandler<EventArgs<string>> Search;

        private void onSearch(bool? isEmptyQuery = null)
        {
            if (this.Search == null)
            {
                //string msg = "Search is null";
                //System.Diagnostics.Debug.WriteLine(msg);

                return;
            }

            if (isEmptyQuery.HasValue == true && isEmptyQuery.Value == true)
            {
                Search.Invoke(this, new EventArgs<string>(string.Empty));
            }
            else
            {
                Search.Invoke(this, new EventArgs<string>(this.txtFilter.Text));
            }
        }
    }
}
