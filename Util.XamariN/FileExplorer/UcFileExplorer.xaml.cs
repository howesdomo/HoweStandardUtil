using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Util.XamariN.FileExplorer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Util.XamariN.FileExplorer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UcFileExplorer : ContentView
    {
        public UcFileExplorer()
        {
            InitializeComponent();

            if (this.BindingContext != null)
            {
                var vm = this.BindingContext as FileExplorer_ViewModel;
                vm.initDataTemplate((DataTemplate)this.Resources["normalMode"], (DataTemplate)this.Resources["selectMode"]);
            }

            this.BindingContextChanged += UcFileExplorer_BindingContextChanged;
        }

        private void UcFileExplorer_BindingContextChanged(object sender, EventArgs e)
        {
            if (this.BindingContext is FileExplorer_ViewModel)
            {
                var vm = this.BindingContext as FileExplorer_ViewModel;
                vm.initDataTemplate((DataTemplate)this.Resources["normalMode"], (DataTemplate)this.Resources["selectMode"]);
            }

        }
    }
}