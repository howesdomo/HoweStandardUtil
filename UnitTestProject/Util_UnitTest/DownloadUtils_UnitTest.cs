using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DownloadUtils_UnitTest
    {
        [TestMethod]
        public void DownloadUtils_Test1()
        {
            bool isContinue = true;

            System.ComponentModel.BackgroundWorker mBgWorker = null;

            if (mBgWorker != null && mBgWorker.IsBusy == true)
            {
                return;
            }

            mBgWorker = new System.ComponentModel.BackgroundWorker();
            mBgWorker.DoWork += (bgSender, bgArgs) =>
            {
                var objArgs = bgArgs.Argument as object[];
                UpdateInfo _updateInfo_ = objArgs[0] as UpdateInfo;
                new Util.DownloadUtils().DownloadFileByHttpRequest
                (
                    requestUri: _updateInfo_.Url,
                    fileLength: _updateInfo_.FileLength,
                    saveFileFolder: System.IO.Path.Combine(Environment.CurrentDirectory, "UpdateAPKs"),
                    renameDownloadFileName: string.Empty, // 直接取默认文件名
                    backgroundWorker: mBgWorker,
                    eventArgs: bgArgs
                );
            };

            mBgWorker.RunWorkerCompleted += (bgSender, bgResult) =>
            {
                if (bgResult.Error != null)
                {
                    string msg = $"{bgResult.Error.GetFullInfo()}";
                    System.Diagnostics.Debug.WriteLine(msg);

                    Assert.IsNull(bgResult.Error);
                }
                else
                {
                    string msg = "下载完毕";
                    System.Diagnostics.Debug.WriteLine(msg);

                    Assert.AreEqual(System.IO.Path.Combine(Environment.CurrentDirectory, "UpdateAPKs", "ENPOT_GBL_CT_V1.0.13.apk"), bgResult.Result);
                }

                isContinue = false;
            };

            mBgWorker.WorkerReportsProgress = true;
            mBgWorker.ProgressChanged += (bgSender, bgArgs) =>
            {
                string msg = $"下载进度:{bgArgs.ProgressPercentage}%";
                System.Diagnostics.Debug.WriteLine(msg);
            };

            mBgWorker.RunWorkerAsync(new object[] { new UpdateInfo()
            {
                Platform = "Android",
                IsLastestVersion = false,
                IsForceUpdate = true,
                Version = 13,
                Url = "http://192.168.1.215:17911/AppWebApplication461/Update/Android/ENPOT_GBL_CT_V1.0.13.apk",
                FileLength = 240402944,
                Message = "确认下载?"
            }});

            // 阻塞主线程, 让 backgroundWork 可以继续执行
            while (isContinue)
            {
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class UpdateInfo
    {
        /// <summary>
        /// 平台
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// 当前为最新版本
        /// </summary>
        public bool IsLastestVersion { get; set; }

        /// <summary>
        /// 强制用户更新到最新版本
        /// </summary>
        public bool IsForceUpdate { get; set; }

        /// <summary>
        /// 更新提示语句
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 文件长度
        /// </summary>
        public long FileLength { get; set; }

        /// <summary>
        /// 安卓下载地址
        /// </summary>
        public string AndroidURL { get; set; }
        public string AndroidURL_Debug { get; set; }

        /// <summary>
        /// 苹果下载地址
        /// </summary>
        public string iOSURL { get; set; }
        public string iOSURL_Debug { get; set; }

        /// <summary>
        /// 是 Debug模式
        /// 若是 ( >0 ) 返回 本机能方便调试的URL
        /// 若是 ( =0 ) 返回 app.enpot.com.cn 的URL
        /// </summary>
        public int DebugMode { get; set; }

    }
}
