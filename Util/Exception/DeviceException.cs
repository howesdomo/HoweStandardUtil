using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public class DeviceException : Exception
    {
        public DeviceException(string exMsg) : base(exMsg)
        {

        }

        public DeviceException(string exMsg, Exception innerEx) : base(exMsg, innerEx)
        {

        }
    }

    public class BluetoothException : DeviceException
    {
        public BluetoothException(string exMsg) : base(exMsg)
        {

        }

        public BluetoothException(string exMsg, Exception innerEx) : base(exMsg, innerEx)
        {

        }
    }
}
