using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    /// <summary>
    /// V 1.0.0 - 2020-10-30 14:02:05
    /// 首次创建
    /// </summary>
    public interface IVisitSystemSettingUtils
    {
        void Goto(string str);

        void GotoWireless();

        void GotoWifi();

        void GotoBluetooth();

        void GotoNFC();

        void GotoDate();

        void GotoGPS();
    }
}
