using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public interface IAndroidIntentUtils
    {
        /// <summary>
        /// 打开APK安装器界面
        /// </summary>
        /// <param name="filePath"></param>
        void InstallAPK(string filePath);

        /// <summary>
        /// 设置 FileProvider 的 Authority
        /// 根据 AndroidManifest.xml 里面设置的 provider - android:authorities
        /// </summary>
        /// <param name="value"></param>
        void SetFileProvider_Authority(string value);
    }
}
