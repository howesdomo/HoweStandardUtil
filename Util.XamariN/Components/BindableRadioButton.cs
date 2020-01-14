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
    public class BindableRadioButton : ContentView
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

        public new int Id { get; set; }


        CheckBox mckb { get; set; }
        Label mlbl { get; set; }

        public BindableRadioButton()
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
            this.BindingContextChanged += CustomRadioButton_BindingContextChanged;

            this.mckb.CheckedChanged += checkedChanged;

            Binding binding = new Binding("IsChecked");
            binding.Source = this;
            binding.Mode = BindingMode.TwoWay;

            this.mckb.SetBinding(CheckBox.IsCheckedProperty, binding);
        }

        private void checkedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.CheckedChanged != null)
            {
                this.CheckedChanged.Invoke(this, new EventArgs<bool>(e.Value));
            }
        }

        private void CustomRadioButton_BindingContextChanged(object sender, EventArgs e)
        {
            dynamic d = this.BindingContext;

            // Step 1
            try
            {
                mlbl.Text = d.DisplayName;
            }
            catch (Exception)
            {
                mlbl.Text = this.BindingContext.ToString();
            }

            // Step 2
            try
            {
                this.IsChecked = d.IsChecked;
            }
            catch (Exception)
            {

            }
        }
    }
}
