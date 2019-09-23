using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Util
{
    /// <summary>
    /// V 1.0.3 - 2019-09-03 优化 UI 下载进度提示频率 (约每下载 512KB 提示一次), 优化下载缓存(约每下载 8MB 将内容写入存储设备)
    /// V 1.0.2 - 2019-09-02 DownloadFileByHttpRequest 修改处理异常方式, 有错直接抛错, 执行成功将下载文件路径传到 eventArgs.Result
    /// V 1.0.1 - 2019-09-02 DownloadFileByHttpRequest 增加参数 saveFileFolder, 设置下载文件的存放位置
    /// </summary>
    public class DownloadUtils
    {
        /// <summary>
        /// 大多数文件系统都配置为使用4096或8192的块大小。
        /// 理论上，如果配置缓冲区大小使得读取比磁盘块多几个字节，
        /// 则使用文件系统的操作可能效率极低（即，如果您将缓冲区配置为一次读取4100个字节，
        /// 每次读取将需要文件系统进行2次块读取。如果块已经在缓存中，
        /// 那么你最终会支付RAM的价格 - > L3 / L2缓存延迟。
        /// 如果你运气不好并且块还没有缓存，那么你也需要支付磁盘 - > RAM延迟的价格。
        /// </summary>
        public static int s_BufferSize
        {
            get
            {
                return 8192;
            }
        }

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
                throw new Exception("出现异常。（判断 新建下载任务 OR 断点续传）", ex);
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

                byte[] arr = new byte[s_BufferSize];
                int len = 0;
                len = responseStream.Read(arr, 0, arr.Length);
                int toflushCount = 0;
                while (len > 0)
                {
                    fileStream.Write(arr, 0, len);
                    len = responseStream.Read(arr, 0, arr.Length);
                    if (backgroundWorker != null)
                    {
                        currentPosition += len;
                        if (toflushCount > 0 && toflushCount % 64 == 0) // 约每下载 512KB 提示一次
                        {
                            int percent = Convert.ToInt32(((currentPosition * 100L) / (fileLength) * 100L) / 100L);
                            backgroundWorker.ReportProgress(percent);
                        }
                    }

                    // 减少磁盘访问次数，需要好好控制 Flush() 的时机
                    if (toflushCount != 0 && toflushCount % 1024 == 0) // 约每下载 8MB 将内容写入存储设备
                    {
                        fileStream.Flush(flushToDisk: true);
                        System.Diagnostics.Debug.WriteLine("Flush");
                    }
                    toflushCount = toflushCount + 1;
                }

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

                throw new Exception("出现异常。（下载文件）", ex);
            }

            #endregion

            #region 下载完毕 重命名下载文件

            try
            {
                if (File.Exists(finalFilePath) == true)  // 删除已存在的文件
                {
                    File.Delete(finalFilePath);
                }

                File.Move(tmpFilePath, finalFilePath); // 重命名 - 将.hdl下载文件移动到最终路径

                if (backgroundWorker != null)
                {
                    backgroundWorker.ReportProgress(200);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("出现异常。（下载完毕 重命名下载文件）", ex);
            }

            #endregion

            if (eventArgs != null)
            {
                eventArgs.Result = finalFilePath; // 执行成功, 传出下载文件路径
            }
        }
    }
}
