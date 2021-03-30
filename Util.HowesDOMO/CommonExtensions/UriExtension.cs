using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    /// <summary>
    /// V 1.0.0 - 2021-03-30 16:25:01
    /// 为 Uri 增加扩展方法 Combine
    /// </summary>
    public static class UriExtension
    {
        public static Uri Combine(this Uri uri, string path)
        {
            return Util.UriUtils.Combine(uri, path);
        }
    }
}
