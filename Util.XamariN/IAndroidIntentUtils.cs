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
    }
}
