using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.FileExplorer
{
    /// <summary>
    /// V 1.0.1 - 2020-8-25 14:53:42
    /// 1 优化返回按钮逻辑，使其兼容 Shell / PopAsync / PopModalAsync
    /// 2 构造函数增加支持无参 ( 不传递 baseDirectory 则默认为内部的 Files文件夹 )
    /// 
    /// V 1.0.0 - 2020-08-23 14:53:27
    /// 首次创建
    /// </summary>
    public class MyFileExplorer : ContentPage
    {
        public string ExitConfirmMessage { get; set; } = "确认退出 FileExplorer？";

        FileExplorer_ViewModel vm { get; set; }

        public MyFileExplorer()
        {
            init("");
        }

        public MyFileExplorer(string baseDirectory)
        {
            init(baseDirectory);
        }

        void init(string baseDirectory)
        {
            var uc = new UcFileExplorer();
            this.Content = uc;

            if (baseDirectory.IsNullOrWhiteSpace() == true)
            {
                this.vm = new FileExplorer_ViewModel();
            }
            else
            {
                this.vm = new FileExplorer_ViewModel(baseDirectory);
            }

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
                        System.Diagnostics.Debug.WriteLine("MyFileExplorer用户选择了退出");

                        if (Navigation != null)
                        {
                            if (Navigation.ModalStack.Count > 0)
                            {
                                System.Diagnostics.Debug.WriteLine("Navigation.PopModalAsync()");
                                await Navigation.PopModalAsync();
                            }
                            else if (Navigation.NavigationStack.Count > 1)
                            {
                                System.Diagnostics.Debug.WriteLine("Navigation.PopAsync()");
                                await Navigation.PopAsync();
                            }
                        }
                        else if (Shell.Current != null)
                        {
                            System.Diagnostics.Debug.WriteLine("Shell.Current.GoToAsync(\"..\")");
                            await Shell.Current.GoToAsync("..");
                        }
                    }
                });
            }

            return true;
        }

        public static IShareUtils ShareUtils { get; set; }
    }
}
