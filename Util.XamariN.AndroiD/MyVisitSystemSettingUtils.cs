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
    /// V 1.0.0 - 2020-10-30 14:02:05
    /// 首次创建, 实现安卓版本前往系统设置页面
    /// </summary>
    public class MyVisitSystemSettingUtils : IVisitSystemSettingUtils
    {
        public void Goto(string str)
        {
            Intent intent = new Intent(str);
            intent.SetFlags(ActivityFlags.NewTask);
            Android.App.Application.Context.StartActivity(intent);
        }

        public void GotoWireless()
        { 
            Goto(Android.Provider.Settings.ActionWirelessSettings);
        }

        public void GotoWifi()
        {
            Goto(Android.Provider.Settings.ActionWifiSettings);
        }

        public void GotoBluetooth()
        { 
            Goto(Android.Provider.Settings.ActionBluetoothSettings);
        }

        public void GotoNFC()
        { 
            Goto(Android.Provider.Settings.ActionNfcSettings);
        }

        public void GotoDate()
        {
            Goto(Android.Provider.Settings.ActionDateSettings);
        }

        public void GotoGPS()
        {
            Goto(Android.Provider.Settings.ActionLocationSourceSettings);
        }
    }
}