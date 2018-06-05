using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Util.IO
{
    public class FileUtils
    {
        /// <summary>
        /// 读取文件为Base64Str
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileToBase64Str(string filePath)
        {
            string base64Str = string.Empty;

            string finalPath = Path.Combine
            (
                Environment.CurrentDirectory,
                "Temp",
                "DeleteAfterRead",
                "{0}{1}".FormatWith(Guid.NewGuid().ToString(), new FileInfo(filePath).Extension)
            );

            FileInfo fi = new FileInfo(finalPath);

            if (Directory.Exists(fi.Directory.FullName) == false)
            {
                Directory.CreateDirectory(fi.Directory.FullName);
            }

            File.Copy(filePath, finalPath);

            using (FileStream filestream = new FileStream(finalPath, FileMode.Open))
            {
                byte[] byteArry = new byte[filestream.Length];
                filestream.Read(byteArry, 0, byteArry.Length);
                base64Str = Convert.ToBase64String(byteArry);
            }

            File.Delete(finalPath);

            return base64Str;
        }

        /// <summary>
        /// Base64Str存储到文件
        /// </summary>
        /// <param name="filePath">文件存放位置</param>
        /// <param name="base64Str">文件base64字符串</param>
        /// <param name="ignoreExistFile">忽略已存在文件，若 true 删除文件</param>
        public static void SaveBase64StrToFile(string filePath, string base64Str, bool ignoreExistFile = false)
        {
            byte[] byteArray;

            try
            {
                byteArray = Convert.FromBase64String(base64Str);
            }
            catch (Exception ex)
            {
                string errorMsg = "执行Util.IO.FileUtils.SaveBase64StrToFile发生错误。";
                throw new Exception(errorMsg, ex);
            }

            FileInfo fi = new FileInfo(filePath);

            if (Directory.Exists(fi.Directory.FullName) == false)
            {
                Directory.CreateDirectory(fi.Directory.FullName);
            }

            if (fi.Exists == true)
            {
                if (ignoreExistFile == true)
                {
                    File.Delete(filePath);
                }
                else
                {
                    throw new Exception("文件已存在。");
                }
            }

            using (FileStream filestream = new FileStream(filePath, FileMode.CreateNew))
            {
                filestream.Write(byteArray, 0, byteArray.Length);
            }
        }

        public static string GetString(string filePath)
        {
            string r = string.Empty;

            using (FileStream filestream = new FileStream(filePath, FileMode.Open))
            {
                byte[] byteArry = new byte[filestream.Length];
                filestream.Read(byteArry, 0, byteArry.Length);
                r = Convert.ToString(byteArry);
            }

            return r;
        }
    }
}
