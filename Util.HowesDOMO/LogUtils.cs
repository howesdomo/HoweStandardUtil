using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class LogUtils
    {
        public static void Log(string content, DateTime? datetime = null, string fileNameDateTimeTemplate = "yyyyMMdd", string baseDirectory = null)
        {
            if (datetime.HasValue == false)
            {
                datetime = DateTime.Now;
            }

            string path = System.IO.Path.Combine
            (
                baseDirectory == null ? Environment.CurrentDirectory : baseDirectory,
                "Logs_{0}.txt".FormatWith(datetime.Value.ToString(fileNameDateTimeTemplate))
            );

            FileInfo fi = new FileInfo(path);
            if (System.IO.Directory.Exists(fi.Directory.FullName) == false)
            {
                System.IO.Directory.CreateDirectory(fi.Directory.FullName);
            }

            FileMode fileMode = FileMode.OpenOrCreate;
            if (fi.Exists == true)
            {
                fileMode = FileMode.Append;
            }

            using (FileStream fs = new FileStream(fi.FullName, fileMode, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("******** {0} ********".FormatWith(datetime.Value.ToString("yyyy-MM-dd HH:mm:ss.fffffff")));
                    sw.WriteLine(content);
                }
            }
        }

        public static void LogAsync(string content, DateTime? datetime = null, string fileNameDateTimeTemplate = "yyyyMMdd", string baseDirectory = null, Action<Task> handler = null)
        {
            Task task = new Task(() => Log(content, datetime, fileNameDateTimeTemplate, baseDirectory));

            if (handler != null)
            {
                task.ContinueWith(handler);
            }

            task.Start();
        }

        //public static void WebServiceLog(string content, DateTime? datetime = null, string fileNameDateTimeTemplate = "yyyyMMdd")
        //{
        //    Log(content, datetime, fileNameDateTimeTemplate, System.Web.Hosting.HostingEnvironment.MapPath("~"));
        //}

        //public static void WebServiceLogAsync(string content, DateTime? datetime = null, string fileNameDateTimeTemplate = "yyyyMMdd", Action<Task> handler = null)
        //{
        //    Task task = new Task(() => Log(content, datetime, fileNameDateTimeTemplate, System.Web.Hosting.HostingEnvironment.MapPath("~")));

        //    if (handler != null)
        //    {
        //        task.ContinueWith(handler);
        //    }

        //    task.Start();
        //}
    }
}
