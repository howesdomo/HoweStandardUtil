using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.FileExplorer
{
    public class MyFileExplorer : ContentPage
    {
        public string ExitConfirmMessage { get; set; } = "确认退出 FileExplorer？";

        FileExplorer_ViewModel vm { get; set; }

        public MyFileExplorer(string baseDirectory)
        {
            var uc = new UcFileExplorer();
            this.Content = uc;

            this.vm = new FileExplorer_ViewModel(baseDirectory);
            uc.BindingContext = this.vm;
        }

        protected override bool OnBackButtonPressed()
        {
            if (vm.HandleBackButtonPress() == false)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var d = await Acr.UserDialogs.UserDialogs.Instance.ConfirmAsync(this.ExitConfirmMessage, "提示", "确认", "返回");
                    if (d == true)
                    {
                        await Navigation.PopAsync();
                    }
                });
            }

            return true;
        }
    }
}
