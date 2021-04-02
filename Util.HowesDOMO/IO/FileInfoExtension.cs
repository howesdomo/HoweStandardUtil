using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.IO
{
    /// <summary>
    /// V 1.0.1 - 2021-04-02 11:45:12
    /// 获取文件的MD5值
    /// 
    /// V 1.0.0 - 2019-09-28 11:27:00
    /// NameWithoutExtension ( 获取一个没有.的扩展名称 )
    /// </summary>
    public static class FileInfoExtension
    {
        /// <summary>
        /// 获取一个没有.的扩展名称
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        public static string NameWithoutExtension(this System.IO.FileInfo fileInfo)
        {
            return Util.IO.FileUtils.GetFileNameWithoutExtension(fileInfo);
        }

        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public static string MD5(this FileInfo fi)
        {
            if (fi.Exists == false)
            {
                throw new ArgumentException($"文件不存在。\r\n{fi.FullName}");
            }

            return Util.IO.FileUtils.MD5(fi);
        }
    }
}
