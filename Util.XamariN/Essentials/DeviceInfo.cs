using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN.Essentials
{

    public class DeviceInfo
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public string DeviceName { get; set; }

        public int VersionMajor { get; set; }

        public int VersionMinor { get; set; }

        public int VersionBuild { get; set; }

        public int VersionRevision { get; set; }

        public string VersionInfo { get; set; }

        public string Platform { get; set; }

        public string Idiom { get; set; }

        public string DeviceType { get; set; }

        public override string ToString()
        {
            return string.Format("Model:{0}\r\nManufacturer:{1}\r\nDeviceName:{2}\r\nVersion:{3}\r\nPlatform:{4}\r\nIdiom:{5}\r\nDeviceType:{6}",
                this.Model, this.Manufacturer, this.DeviceName, this.VersionInfo, this.Platform, this.Idiom, this.DeviceType);
        }
    }
}
