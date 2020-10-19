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
    /// <summary>
    /// V 1.0.0 - 2020-10-13 17:36:50
    /// 首次创建, 常用的分享功能初步实现, 待完善
    /// </summary>
    public class MyShareUtils : Util.XamariN.IShareUtils
    {
        public void ShareMsg(string msg, List<string> filters = null, string chooserTitle = "")
        {
            var context = Android.App.Application.Context;

            string contentTypeOfMIME = "text/plain";

            Intent share = new Intent(Android.Content.Intent.ActionSend);
            share.SetType(contentTypeOfMIME);

            List<Intent> targetedShareIntents = new List<Intent>();

            var query = context.PackageManager.QueryIntentActivities(share, (Android.Content.PM.PackageInfoFlags)0);

            foreach (Android.Content.PM.ResolveInfo resolveInfo in query)
            {
                // string msg = $"{item.ActivityInfo.PackageName}; {item.ActivityInfo.Name}";
                // ActivityInfo.PackageName : com.tencent.mm
                // ActivityInfo.Name : com.tencentt.mm.ui.tools.ShareImgUI

                if (filters != null) // 程序员设置过滤条件
                {
                    if (filters.Any(i => resolveInfo.ActivityInfo.PackageName.Contains(i, StringComparison.CurrentCultureIgnoreCase)
                    || resolveInfo.ActivityInfo.Name.Contains(i, StringComparison.CurrentCultureIgnoreCase)) == false)
                    {
                        continue; // 不满足过滤条件
                    }
                }

                Intent origIntent = new Intent(Intent.ActionSend);
                origIntent.SetType(contentTypeOfMIME);

                origIntent.PutExtra(Intent.ExtraText, msg);
                origIntent.SetComponent(new Android.Content.ComponentName(pkg: resolveInfo.ActivityInfo.PackageName, cls: resolveInfo.ActivityInfo.Name));

                var intentToAdd = new Android.Content.PM.LabeledIntent
                (
                    origIntent: origIntent,
                    sourcePackage: resolveInfo.ActivityInfo.PackageName,
                    nonLocalizedLabel: resolveInfo.LoadLabel(pm: context.PackageManager),
                    icon: resolveInfo.ActivityInfo.Icon
                );

                targetedShareIntents.Add(intentToAdd);
            }

            if (targetedShareIntents.Count <= 0)
            {
                string errMsg = $"找不到相关应用。";
                if (filters != null)
                {
                    errMsg += "filters:";
                    foreach (var item in filters)
                    {
                        errMsg += "\r\n" + item;
                    }
                }
                throw new Exception(errMsg);
            }

            Intent chooserIntent = Intent.CreateChooser(new Intent(), $"分享到{chooserTitle}");
            var flags = ActivityFlags.ClearTop | ActivityFlags.NewTask; // https://github.com/xamarin/Essentials/blob/main/Xamarin.Essentials/Share/Share.android.cs
            chooserIntent.SetFlags(flags);

            IParcelable[] args = new IParcelable[targetedShareIntents.Count];
            for (int i = 0; i < targetedShareIntents.Count; i++)
            {
                args[i] = targetedShareIntents[i];
            }

            chooserIntent.PutExtra(Intent.ExtraInitialIntents, args);

            Android.App.Application.Context.StartActivity(chooserIntent);
        }

        #region ShareMsg

        public void ShareMsg(string msg, string filter, string chooserTitle = "")
        {
            List<string> filters = null;

            if (string.IsNullOrWhiteSpace(filter) == false)
            {
                filters = new List<string>(1) { filter };
            }

            ShareMsg(msg, filters, chooserTitle);
        }

        public void ShareMsg2WeChat(string msg)
        {
            ShareMsg(msg, "com.tencent.mm", "微信(WeChat)");
        }

        public void ShareMsg2QQ(string msg)
        {
            ShareMsg(msg, "com.tencent.mobileqq", "QQ");
        }

        public void ShareMsg2TIM(string msg)
        {
            ShareMsg(msg, "com.tencent.tim", "TIM");
        }

        public void ShareMsg2EStrongs(string msg)
        {
            ShareMsg(msg, "com.estrongs", "ES文件管理器");
        }

        #endregion

        public void ShareFile(string filePath, List<string> filters = null, string chooserTitle = "")
        {
            Java.IO.File file_JavaIO = new Java.IO.File(filePath);
            if (file_JavaIO.Exists() == false)
            {
                throw new Exception("文件不存在");
            }

            var context = Android.App.Application.Context;
            string contentTypeOfMIME = new Xamarin.Essentials.ShareFile(filePath).ContentType;

            Intent share = new Intent(Android.Content.Intent.ActionSend);
            share.SetType(contentTypeOfMIME);

            List<Intent> targetedShareIntents = new List<Intent>();

            var query = Android.App.Application.Context.PackageManager.QueryIntentActivities(share, (Android.Content.PM.PackageInfoFlags)0);

            foreach (Android.Content.PM.ResolveInfo resolveInfo in query)
            {
                // string msg = $"{item.ActivityInfo.PackageName}; {item.ActivityInfo.Name}";
                // ActivityInfo.PackageName : com.tencent.mm
                // ActivityInfo.Name : com.tencentt.mm.ui.tools.ShareImgUI

                if (filters != null) // 程序员设置过滤条件
                {
                    if (filters.Any(i => resolveInfo.ActivityInfo.PackageName.Contains(i, StringComparison.CurrentCultureIgnoreCase)
                        || resolveInfo.ActivityInfo.Name.Contains(i, StringComparison.CurrentCultureIgnoreCase)) == false)
                    {
                        continue; // 不满足过滤条件
                    }
                }

                Intent origIntent = new Intent(Intent.ActionSend);
                origIntent.SetType(contentTypeOfMIME);
                origIntent.AddFlags(Android.Content.ActivityFlags.GrantReadUriPermission | Android.Content.ActivityFlags.GrantWriteUriPermission); // 发图片
                origIntent.SetAction(Intent.ActionSend); // 发图片

                Android.Net.Uri uri = null;

                if
                (
                    context.ApplicationInfo.TargetSdkVersion >= Android.OS.BuildVersionCodes.N
                    && Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.N
                )
                {
                    var providerAuthority = Android.App.Application.Context.PackageName + ".fileProvider";
                    uri = Xamarin.Essentials.FileProvider.GetUriForFile
                    (
                        context: context,
                        authority: providerAuthority,
                        file: new Java.IO.File(filePath)
                    );
                }
                else
                {
                    // uri = Android.Net.Uri.FromFile("TODO"); // 不再使用路径 导致这里是没有参数的                
                }

                origIntent.PutExtra(Intent.ExtraStream, uri);

                origIntent.SetComponent(new Android.Content.ComponentName(pkg: resolveInfo.ActivityInfo.PackageName, cls: resolveInfo.ActivityInfo.Name));

                var intentToAdd = new Android.Content.PM.LabeledIntent
                (
                    origIntent: origIntent,
                    sourcePackage: resolveInfo.ActivityInfo.PackageName,
                    nonLocalizedLabel: resolveInfo.LoadLabel(pm: Android.App.Application.Context.PackageManager),
                    icon: resolveInfo.ActivityInfo.Icon
                );

                targetedShareIntents.Add(intentToAdd);
            }

            if (targetedShareIntents.Count <= 0)
            {
                string msg = $"找不到相关应用。";
                if (filters != null)
                {
                    msg += "filters:";
                    foreach (var item in filters)
                    {
                        msg += "\r\n" + item;
                    }
                }
                throw new Exception(msg);
            }

            Intent chooserIntent = Intent.CreateChooser(target: new Intent(), title: $"分享到{chooserTitle}");
            var flags = ActivityFlags.ClearTop | ActivityFlags.NewTask; // 参考自 https://github.com/xamarin/Essentials/blob/main/Xamarin.Essentials/Share/Share.android.cs
            chooserIntent.SetFlags(flags);

            IParcelable[] args = new IParcelable[targetedShareIntents.Count];
            for (int i = 0; i < targetedShareIntents.Count; i++)
            {
                args[i] = targetedShareIntents[i];
            }

            chooserIntent.PutExtra(Intent.ExtraInitialIntents, args);

            Android.App.Application.Context.StartActivity(chooserIntent);
        }

        #region ShareFile

        public void ShareFile(string filePath, string filter, string chooserTitle = "")
        {
            List<string> filters = null;

            if (string.IsNullOrWhiteSpace(filter) == false)
            {
                filters = new List<string>(1) { filter };
            }

            ShareFile(filePath, filters, chooserTitle);
        }

        public void ShareFile2WeChat(string filePath)
        {
            ShareFile(filePath, "com.tencent.mm", "微信(WeChat)");
        }

        public void ShareFile2QQ(string filePath)
        {
            ShareFile(filePath, "com.tencent.mobileqq", "QQ");
        }

        public void ShareFile2TIM(string filePath)
        {
            ShareFile(filePath, "com.tencent.tim", "TIM");
        }

        public void ShareFile2EStrongs(string filePath)
        {
            ShareFile(filePath, "com.estrongs", "ES文件管理器");
        }

        #endregion


        /// <summary>
        /// 分享
        /// 图片不保存在文件
        /// 
        /// 类似于某些打卡软件，不会将文件存储到文件
        /// </summary>
        private void shareImageByChooser(Android.Graphics.Bitmap bitmap, List<string> filters = null, string chooserTitle = "")
        {
            var context = Android.App.Application.Context;
            string contentTypeOfMIME = "image/*";

            Intent share = new Intent(Android.Content.Intent.ActionSend);
            share.SetType(contentTypeOfMIME);

            List<Intent> targetedShareIntents = new List<Intent>();

            var query = Android.App.Application.Context.PackageManager.QueryIntentActivities(share, (Android.Content.PM.PackageInfoFlags)0);

            foreach (Android.Content.PM.ResolveInfo resolveInfo in query)
            {
                // string msg = $"{item.ActivityInfo.PackageName}; {item.ActivityInfo.Name}";
                // ActivityInfo.PackageName : com.tencent.mm
                // ActivityInfo.Name : com.tencentt.mm.ui.tools.ShareImgUI

                if (filters != null) // 程序员设置过滤条件
                {
                    if (filters.Any(i => resolveInfo.ActivityInfo.PackageName.Contains(i) || resolveInfo.ActivityInfo.Name.Contains(i)) == false)
                    {
                        continue; // 不满足过滤条件
                    }
                }

                Intent origIntent = new Intent(Intent.ActionSend);
                origIntent.SetType(contentTypeOfMIME);
                origIntent.AddFlags(Android.Content.ActivityFlags.GrantReadUriPermission | Android.Content.ActivityFlags.GrantWriteUriPermission); // 发图片
                origIntent.SetAction(Intent.ActionSend); // 发图片

                Android.Net.Uri uri = null;

                if
                (
                    context.ApplicationInfo.TargetSdkVersion >= Android.OS.BuildVersionCodes.N
                    && Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.N
                )
                {
                    var k = Android.Provider.MediaStore.Images.Media.InsertImage
                            (
                                cr: context.ContentResolver,
                                source: bitmap,
                                title: "Share Images",
                                description: "Share Image Description"
                            );

                    if (string.IsNullOrWhiteSpace(k) == true) 
                    {
                        throw new Exception("k值为null，估计是由于未允许读写外部存储器权限引起。\r\nAndroid.Provider.MediaStore.Images.Media.InsertImage");
                    }

                    uri = Android.Net.Uri.Parse(k);
                }
                else
                {
                    // uri = Android.Net.Uri.FromFile("TODO"); // 不再使用路径 导致这里是没有参数的                
                }

                origIntent.PutExtra(Intent.ExtraStream, uri);

                origIntent.SetComponent(new Android.Content.ComponentName(pkg: resolveInfo.ActivityInfo.PackageName, cls: resolveInfo.ActivityInfo.Name));

                var intentToAdd = new Android.Content.PM.LabeledIntent
                (
                    origIntent: origIntent,
                    sourcePackage: resolveInfo.ActivityInfo.PackageName,
                    nonLocalizedLabel: resolveInfo.LoadLabel(pm: Android.App.Application.Context.PackageManager),
                    icon: resolveInfo.ActivityInfo.Icon
                );

                targetedShareIntents.Add(intentToAdd);
            }

            if (targetedShareIntents.Count <= 0)
            {
                string msg = $"找不到相关应用。";
                if (filters != null)
                {
                    msg += "filters:";
                    foreach (var item in filters)
                    {
                        msg += "\r\n" + item;
                    }
                }
                throw new Exception(msg);
            }

            Intent chooserIntent = Intent.CreateChooser(target: new Intent(), title: $"分享到{chooserTitle}");
            var flags = ActivityFlags.ClearTop | ActivityFlags.NewTask; // 参考自 https://github.com/xamarin/Essentials/blob/main/Xamarin.Essentials/Share/Share.android.cs
            chooserIntent.SetFlags(flags);

            IParcelable[] args = new IParcelable[targetedShareIntents.Count];
            for (int i = 0; i < targetedShareIntents.Count; i++)
            {
                args[i] = targetedShareIntents[i];
            }

            chooserIntent.PutExtra(Intent.ExtraInitialIntents, args);

            Android.App.Application.Context.StartActivity(chooserIntent);

        }

        #region ShareImage

        public void ShareImage(byte[] imageData, List<string> filters = null, string chooserTitle = "")
        {
            var bitmap = Android.Graphics.BitmapFactory.DecodeByteArray(imageData, 0, imageData.Length);
            shareImageByChooser(bitmap, filters, chooserTitle);
        }

        public void ShareImage(System.Drawing.Bitmap bitmapFromSystemDrawing, List<string> filters = null, string chooserTitle = "")
        {
            byte[] imageData = null;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bitmapFromSystemDrawing.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageData = ms.ToArray();
            }
            var bitmap = Android.Graphics.BitmapFactory.DecodeByteArray(imageData, 0, imageData.Length);
            shareImageByChooser(bitmap, filters, chooserTitle);
        }

        #endregion

        /// <summary>
        /// 分享信息到指定程序
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="activityName"></param>
        /// <param name="appname"></param>
        /// <param name="msgTitle"></param>
        /// <param name="msgText"></param>
        public void ShareMsg2Xxx
        (
            string packageName,
            string activityName,
            string appname,
            string msgTitle,
            string msgText
        )
        {
            var context = Android.App.Application.Context;

            if (isAvilible(context, packageName) == false)
            {
                throw new Exception($"未安装 {appname}");
            }

            Intent intent = new Intent("android.intent.action.SEND");
            var flags = ActivityFlags.ClearTop | ActivityFlags.NewTask;
            intent.SetFlags(flags);
            intent.SetType("text/plain");
            intent.PutExtra(Intent.ExtraSubject, msgTitle);
            intent.PutExtra(Intent.ExtraText, msgText);

            intent.SetComponent(new Android.Content.ComponentName(pkg: packageName, cls: activityName));
            context.StartActivity(intent);
        }

        /// <summary>
        /// 判断相对应的APP是否存在
        /// </summary>
        /// <param name="context"></param>
        /// <param name="packageName"></param>
        /// <returns></returns>
        bool isAvilible(Context context, string packageName)
        {
            Android.Content.PM.PackageManager packageManager = context.PackageManager;

            var pinfo = packageManager.GetInstalledPackages(Android.Content.PM.PackageInfoFlags.Activities);

            foreach (var item in pinfo)
            {
                if (item.PackageName.Equals(packageName, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

    }
}