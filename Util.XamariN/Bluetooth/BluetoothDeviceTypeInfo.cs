using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public class BluetoothDeviceTypeInfo
    {
        public BluetoothDeviceTypeInfo(int value)
        {
            switch (value)
            {
                case 0:
                    {
                        this.Value = value;
                        this.Name = "Unknown";
                        this.Description = "Bluetooth device type, Unknown";
                        this.Description_ZH = "未知";
                    }
                    break;
                case 1:
                    {
                        this.Value = value;
                        this.Name = "Classic";
                        this.Description = "Bluetooth device type, Classic - BR/EDR devices";
                        this.Description_ZH = "典型蓝牙";   
                    }
                    break;
                case 2:
                    {
                        // 蓝牙低功耗（Bluetooth Low Energy，或称Bluetooth LE、BLE，旧商标Bluetooth Smart[1]）也称蓝牙低能耗、低功耗蓝牙，
                        // 是蓝牙技术联盟设计和销售的一种个人局域网技术，旨在用于医疗保健、运动健身、信标[2]、安防、家庭娱乐等领域的新兴应用。
                        // 相较经典蓝牙，低功耗蓝牙旨在保持同等通信范围的同时显著降低功耗和成本。
                        this.Value = value;
                        this.Name = "Le";
                        this.Description = "Bluetooth device type, Low Energy - LE-only";
                        this.Description_ZH = "蓝牙低功耗";
                    }
                    break;
                case 3:
                    {
                        // 维基百科
                        // Single mode只能与BT4.0互相传输无法向下兼容（与3.0/2.1/2.0无法相通）;
                        // Dual mode可以向下兼容，可与BT4.0传输也可以跟3.0/2.1/2.0传输
                        this.Value = value;
                        this.Name = "Dual";
                        this.Description = "Bluetooth device type, Dual Mode - BR/EDR/LE";
                        this.Description_ZH = "";
                    }
                    break;
                default:
                    break;
            }
        }

        public int Value { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Description_ZH { get; private set; }
    }
}
