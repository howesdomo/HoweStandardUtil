﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public class BluetoothEvents
    {
        public static EventHandler<BLuetoothEventArgs> UpdateInfo;

        public static void OnUpdateInfo(BLuetoothEventArgs args)
        {
            if (BluetoothEvents.UpdateInfo != null)
            {
                BluetoothEvents.UpdateInfo.Invoke(null, args);
            }
        }
    }

    public class BLuetoothEventArgs : EventArgs
    {
        public Util.XamariN.BluetoothDeviceInfo Update { get; private set; }

        public BLuetoothEventArgs()
        {

        }

        public BLuetoothEventArgs(Util.XamariN.BluetoothDeviceInfo bluetoothDeviceInfo)
        {
            this.Update = bluetoothDeviceInfo;
        }
    }
}
