using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public interface IHardwareBarcodeScanner
    {
        void EnabledScanner();

        void DisabledScanner();
    }
}
