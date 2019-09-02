using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading.Tasks;


namespace Util
{
    /// <summary>
    /// V 1.0.1 - 2019-09-02 DownloadFileByHttpRequest 增加参数 saveFileFolder, 设置下载文件的存放位置
    /// </summary>
    public class DownloadUtils
    {
        Task httpRequestTask = null;

        /// <summary>
        /// 允许开始一个新任务的状态集合
        /// </summary>
        private List<TaskStatus> canStartNewTaskStatus = new List<TaskStatus>()
        {
            TaskStatus.RanToCompletion,
            TaskStatus.Canceled,
            TaskStatus.Faulted
        };

        /// <summary>
        /// (异步)使用HttpRequest下载文件，支持断点续传
        /// 支持 BackgroundWorker ( ReportProgress 和 DoWorkEventArgs )
        /// 百分比 返回 0 ~ 100 正在下载
        /// 返回 200 重命名成功
        /// </summary>
        /// <param name="actionHandler"></param>
        /// <param name="requestUri">Http Uri</param>
        /// <param name="fileLength">文件总长度</param>
        /// <param name="saveFileFolder">下载文件存放路径, 默认值 Environment.CurrentDirectory</param>
        /// <param name="renameDownloadFileName">重命名下载文件，默认值取Uri斜杠后的文件名称，CXY可以重新定义其名称</param>
        public void DownloadFileByHttpRequestAynsc
        (
            Action<Task> actionHandler,
            string requestUri,
            long fileLength,
            string saveFileFolder = "",
            string renameDownloadFileName = ""
        )
        {
            if (httpRequestTask != null && canStartNewTaskStatus.Exists(i => i.Equals(httpRequestTask.Status)) == false)
            {
                throw new Exception("仍有任务下载中，请等待下载完毕或取消任务。");
            }

            httpRequestTask = new System.Threading.Tasks.Task(() =>
                DownloadFileByHttpRequest
                (
                    requestUri: requestUri,
                    fileLength: fileLength,
                    saveFileFolder: saveFileFolder,
                    renameDownloadFileName: renameDownloadFileName
                )
            );
            httpRequestTask.ContinueWith((task) => actionHandler(task));

            httpRequestTask.Start();

            #region (UI代码参考)下载完毕 Handler 可以参考以下代码

            //public void DownloadFileByHttpRequestAynsc_Handler(System.Threading.Tasks.Task task)
            //{
            //    string msg = "IsCanceled={0}\nIsCompleted={1}\nIsFaulted={2};"
            //    .FormatWith
            //    (
            //        task.IsCanceled,  // 因被取消而完成
            //        task.IsCompleted, // 成功完成
            //        task.IsFaulted    // 因发生异常而完成
            //    );

            //    Console.WriteLine(msg);

            //    if (task.IsFaulted == true)
            //    {
            //        if (task.Exception != null)
            //        {
            //            Console.WriteLine(task.IsFaulted);
            //            MessageBox.Show(task.Exception.GetFullInfo());
            //        }
            //        else
            //        {
            //            MessageBox.Show("下载失败。");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("下载完成。");
            //    }
            //}

            #endregion
        }

        /// <summary>
        /// 使用HttpRequest下载文件，支持断点续传
        /// 支持 BackgroundWorker ( ReportProgress 和 DoWorkEventArgs )
        /// 百分比 返回 0 ~ 100 正在下载
        /// 返回 200 重命名成功
        /// </summary>
        /// <param name="requestUri">Http Uri</param>
        /// <param name="fileLength">文件总长度</param>
        /// <param name="saveFileFolder">下载文件存放路径, 默认值 {Environment.CurrentDirectory}/Downloads</param>
        /// <param name="renameDownloadFileName">重命名下载文件，默认值取Uri斜杠后的文件名称，CXY可以重新定义其名称</param>
        /// <param name="backgroundWorker">支持客户端使用BackgroundWorker(可空)</param>
        /// <param name="eventArgs">支持客户端使用BackgroundWorker(可空)</param>
        public void DownloadFileByHttpRequest
        (
            string requestUri,
            long fileLength,
            string saveFileFolder = "",
            string renameDownloadFileName = "",
            BackgroundWorker backgroundWorker = null,
            DoWorkEventArgs eventArgs = null
        )
        {
            if (saveFileFolder.IsNullOrWhiteSpace() == true)
            {
                saveFileFolder = System.IO.Path.Combine(Environment.CurrentDirectory, "Downloads");
            }

            // 文件路径(下载完毕)
            string finalFilePath = System.IO.Path.Combine
            (
                saveFileFolder,
                renameDownloadFileName.IsNullOrEmpty() == true ? requestUri.Substring(requestUri.LastIndexOf('/') + 1) : renameDownloadFileName
            );

            // 文件路径(下载中状态)
            string tmpFilePath = finalFilePath + ".hDL";

            FileInfo fi = new FileInfo(finalFilePath);
            if (System.IO.Directory.Exists(fi.Directory.FullName) == false)
            {
                System.IO.Directory.CreateDirectory(fi.Directory.FullName);
            }

            #region 判断 新建下载任务 OR 断点续传

            long currentPosition = 0; // 当前文件大小

            FileStream fileStream = null;
            try
            {
                if (File.Exists(tmpFilePath)) // 续传
                {
                    fileStream = File.OpenWrite(tmpFilePath);
                    currentPosition = fileStream.Length; // 获取已经下载的长度
                    fileStream.Seek(currentPosition, SeekOrigin.Current);
                }
                else // 新下载任务
                {
                    fileStream = new FileStream(tmpFilePath, FileMode.Create);
                }
            }
            catch (Exception ex)
            {
                if (eventArgs != null)
                {
                    eventArgs.Result = ex.Message;
                }
                return;
            }
            #endregion

            #region 下载文件

            Stream responseStream = null;
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(requestUri) as HttpWebRequest;
                if (currentPosition > 0)
                {
                    // 进行断点续传
                    request.AddRange(Convert.ToInt32(currentPosition)); // *** 设置Range值 *** // long转int若转换失败如何处理?????
                }

                responseStream = request.GetResponse().GetResponseStream();

                byte[] arr = new byte[512];
                int len = 0;
                len = responseStream.Read(arr, 0, arr.Length);
                while (len > 0)
                {
                    fileStream.Write(arr, 0, len);
                    len = responseStream.Read(arr, 0, arr.Length);
                    if (backgroundWorker != null)
                    {
                        currentPosition += len;
                        int percent = Convert.ToInt32(((currentPosition * 100L) / (fileLength) * 100L) / 100L);
                        backgroundWorker.ReportProgress(percent);
                    }
                }
                // 减少磁盘访问次数，需要好好控制 fileStream.Flush() 的时机

                fileStream.Close();
                responseStream.Close();
                if (backgroundWorker != null)
                {
                    backgroundWorker.ReportProgress(100);
                }
            }
            catch (Exception ex)
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }

                if (responseStream != null)
                {
                    responseStream.Close();
                }

                if (eventArgs != null)
                {
                    eventArgs.Result = ex.Message;
                }
                return;
            }

            #endregion

            #region 下载完毕 重命名下载文件

            try
            {
                File.Move(tmpFilePath, finalFilePath); // 重命名
                if (backgroundWorker != null)
                {
                    backgroundWorker.ReportProgress(200);
                }
            }
            catch (Exception ex)
            {
                if (eventArgs != null)
                {
                    eventArgs.Result = ex.Message;
                }
                return;
            }

            #endregion

            if (eventArgs != null)
            {
                eventArgs.Result = string.Empty; // 执行成功    
            }
        }
    }
}
