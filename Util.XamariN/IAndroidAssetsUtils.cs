using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN
{
    public interface IAndroidAssetsUtils
    {
        bool IsExist(string path);

        string GetString(string path);

        System.IO.Stream GetStream(string path);
    }
}
