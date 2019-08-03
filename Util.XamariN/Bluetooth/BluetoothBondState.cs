using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public class BluetoothBondState
    {
        public BluetoothBondState(int value)
        {
            this.Value = value;

            switch (value)
            {

                case 11:
                    this.Info = "Bonding";
                    break;
                case 12:
                    this.Info = "Bonded";
                    break;
                default:
                    this.Info = "None";
                    break;
            }
        }

        public int Value { get; private set; }

        public string Info { get; private set; }
    }
}
