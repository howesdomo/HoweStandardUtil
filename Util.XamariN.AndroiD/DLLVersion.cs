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
    public class DLLVersion
    {
        public string Version { get; private set; }

        public DateTime EntryTime { get; private set; }

        public string Description { get; private set; }


        public static List<DLLVersion> GetDLLVersions()
        {
            List<DLLVersion> history = new List<DLLVersion>();

            history.Add(new DLLVersion() { Version = "1.0.0.0", EntryTime = new DateTime(2019, 8, 3), Description = "优化 Util.Xamarin.AndroiD 项目，由 .net Standard 项目改成 Xamarin.Android, 项目输出设置为 Library( 生成出 DLL 让安卓项目调用 ) " });
            history.Add(new DLLVersion() { Version = "1.0.0.1", EntryTime = new DateTime(2019, 8, 3), Description = "MyScreen 增加 4 个方法, 设置/取消全屏" });
            history.Add(new DLLVersion() { Version = "1.0.1.0", EntryTime = new DateTime(2019, 8, 3), Description = "发布本项目到 Nuget" });

            return history;
        }
    }
}