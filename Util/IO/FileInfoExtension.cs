using System;
using System.Collections.Generic;
using System.Text;

namespace System.IO
{
    public static class FileInfoExtension
    {
        public static string NameWithoutExtension(this System.IO.FileInfo fileInfo)
        {
            return Util.IO.FileUtils.GetFileNameWithoutExtension(fileInfo);
        }

    }
}
