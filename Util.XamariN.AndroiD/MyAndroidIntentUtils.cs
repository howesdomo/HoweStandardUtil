using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Util.XamariN.AndroiD
{
    public class MyAndroidIntentUtils : Util.XamariN.IAndroidIntentUtils
    {
        private Android.App.Activity mAppActivity { get; set; }

        #region 构造函数 + 单例模式

        private MyAndroidIntentUtils()
        {

        }

        private static MyAndroidIntentUtils s_Instance;

        private static object objLock = new object();

        public static MyAndroidIntentUtils GetInstance(Android.App.Activity activity = null)
        {
            lock (objLock)
            {
                if (s_Instance == null)
                {
                    s_Instance = new MyAndroidIntentUtils();
                    if (s_Instance.mAppActivity == null && activity == null)
                    {
                        throw new Exception("MyAndroidIntentUtils.GetInstance 单例首次创建, 请传入 activity 参数");
                    }
                    if (activity != null)
                    {
                        s_Instance.mAppActivity = activity;
                    }
                }
                return s_Instance;
            }
        }

        #endregion

        #region 打开APK安装器界面

        public void InstallAPK(string filePath)
        {
            Java.IO.File apkFileToInstall = new Java.IO.File(filePath);
            if (apkFileToInstall.Exists() == false)
            {
                throw new Exception("文件不存在");
            }

            var version = Xamarin.Essentials.DeviceInfo.Version;

            if (version.Major < 7)
            {
                InstallAPK_Simple(apkFileToInstall);
            }
            else
            {
                InstallAPK_MoreThanAndroid7(apkFileToInstall);
            }
        }

        private void InstallAPK_Simple(Java.IO.File apkFileToInstall)
        {
            Android.Content.Intent intent = new Android.Content.Intent();
            intent.SetAction(Android.Content.Intent.ActionView);
            intent.SetFlags(Android.Content.ActivityFlags.NewTask);
            intent.SetDataAndType(Android.Net.Uri.FromFile(apkFileToInstall), "application/vnd.android.package-archive");
            mAppActivity.Application.StartActivity(intent);
        }

        private string mFileProvider_Authority;

        public void SetFileProvider_Authority(string value)
        {
            mFileProvider_Authority = value;
        }

        public void InstallAPK_MoreThanAndroid7(Java.IO.File apkFileToInstall)
        {
            Android.Content.Intent intent = new Android.Content.Intent();
            intent.SetAction(Android.Content.Intent.ActionView);

            if (string.IsNullOrWhiteSpace(mFileProvider_Authority))
            {
                throw new Exception("mFileProvider_Authority为空值。请使用 SetFileProvider_Authority(string) 方法设置 mFileProvider_Authority 的值。");
            }

            Android.Net.Uri uri = Android.Support.V4.Content.FileProvider.GetUriForFile
            (
                context: mAppActivity.ApplicationContext,
                authority: mFileProvider_Authority,
                file: apkFileToInstall
            );

            intent.SetDataAndType(uri, "application/vnd.android.package-archive");

            intent.SetFlags(Android.Content.ActivityFlags.NewTask); // SetFlags 一定要在 Add Flags 之前, 否则 Add Flags 会被覆盖
            intent.AddFlags(Android.Content.ActivityFlags.GrantReadUriPermission);
            intent.AddFlags(Android.Content.ActivityFlags.GrantWriteUriPermission);

            mAppActivity.Application.StartActivity(intent);
        }

        #endregion
    }
}