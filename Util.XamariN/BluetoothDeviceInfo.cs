using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public class BluetoothDeviceInfo : UIComponent.VirtualModel
    {
        public BluetoothDeviceInfo(string name, string address, int bluetoothDeviceType, int bluetoothBondState)
        {
            this.Name = name;
            this.Address = address;
            this.BluetoothDeviceTypeInfo = new BluetoothDeviceTypeInfo(bluetoothDeviceType);
            this.BluetoothBondState = new BluetoothBondState(bluetoothBondState);
        }

        public string Name { get; private set; }

        public string Address { get; private set; }

        public BluetoothDeviceTypeInfo BluetoothDeviceTypeInfo { get; private set; }

        public BluetoothBondState BluetoothBondState { get; private set; }

        private bool _IsConnected;

        public bool IsConnected
        {
            get { return _IsConnected; }
            set
            {
                _IsConnected = value;
                this.OnPropertyChanged("IsConnected");
                this.OnPropertyChanged("IsConnectedInfo");
            }
        }

        public string IsConnectedInfo
        {
            get
            {
                string r = string.Empty;
                if (this.IsConnected == true)
                {
                    r = "已连接";
                }
                else
                {
                    r = string.Empty;
                }
                return r;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is BluetoothDeviceInfo == false)
            {
                return false;
            }

            var m = obj as BluetoothDeviceInfo;

            if (m.Address == this.Address
                && m.Name == this.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "MAC:{0};Name:{1}".FormatWith(this.Address, this.Name);
        }
    }
}
