using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Util.XamariN.AndroiD
{
    /// <summary>
    /// V 1.0.4 - 2020-06-16 11:11:39
    /// 修复保存路径Bug
    /// 
    /// V 1.0.3 - 2020-06-12 16:35:12
    /// 开始录制执行成功后 返回保存文件路径
    /// 
    /// V 1.0.2 - 2020-06-11 17:01:44
    /// 增强录屏设置 Audio 逻辑, 当前没有录音权限则不对录音进行配置
    /// 
    /// V 1.0.1 - 2020-06-11 14:00:02
    /// 增加接口逻辑, 使 Client 端更方便地使用
    /// 
    /// V 1.0.0 - 2020-06-09 18:51:40
    /// 首次创建
    /// </summary>
    public class MyAndroidScreenRecord : Util.XamariN.IAndroidScreenRecord
    {
        public const int s_ScreenRecord_Request_Code = 3106;

        public static Java.Util.Concurrent.Atomic.AtomicBoolean s_IsRunning = new Java.Util.Concurrent.Atomic.AtomicBoolean(false);

        public static System.IO.FileInfo GetScreenVideoFileInfo(DateTime? dt = null, string dirPath = "")
        {
            if (dt.HasValue == false)
            {
                dt = DateTime.Now;
            }

            if (dirPath.IsNullOrWhiteSpace())
            {
                dirPath = "ScreenRecords";
            }

            Java.IO.File childFolder = Android.App.Application.Context.GetExternalFilesDir("/");

            string exceptionScreenshotsDir = System.IO.Path.Combine(childFolder.AbsolutePath, dirPath);

            string filePath = System.IO.Path.Combine(exceptionScreenshotsDir, $"{dt.Value.ToString("yyyyMMdd_HHmmssfffffff")}.mp4");

            return new System.IO.FileInfo(filePath);
        }


        // =========================== End 静态对象与方法 ===========================

        private Android.App.Activity mAppActivity { get; set; }

        #region 构造函数 + 单例模式

        private MyAndroidScreenRecord(Android.App.Activity activity)
        {
            mAppActivity = activity;

            if (mProjectionManager == null)
            {
                mProjectionManager = (Android.Media.Projection.MediaProjectionManager)mAppActivity.GetSystemService(Android.Content.Context.MediaProjectionService);
            }
        }

        private static MyAndroidScreenRecord s_Instance;

        private static object objLock = new object();

        public static MyAndroidScreenRecord GetInstance(Android.App.Activity activity = null)
        {
            lock (objLock)
            {
                if (s_Instance == null)
                {
                    if (activity == null)
                    {
                        throw new Exception("MyScreenCapture.GetInstance 单例首次创建, 请传入 activity 参数");
                    }

                    s_Instance = new MyAndroidScreenRecord(activity);
                }

                return s_Instance;
            }
        }

        #endregion

        public Android.Media.Projection.MediaProjectionManager mProjectionManager
        {
            get;
            private set;
        }

        public Android.Media.Projection.MediaProjection mProjection
        {
            get;
            private set;
        }

        public Android.Hardware.Display.VirtualDisplay mDisplay
        {
            get;
            private set;
        }

        public Android.Media.MediaRecorder mMediaRecorder
        {
            get;
            private set;
        }

        /// <summary>
        /// 录制视频帧率 默认值30
        /// </summary>
        public int mDpi { get; set; } = 30;

        public void SetDpi(int v)
        {
            mDpi = v;
        }

        /// <summary>
        /// 屏幕截图保存文件夹名称
        /// </summary>
        public string mDirName { get; set; }

        /// <summary>
        /// 时间参数 - 屏幕截图文件名命名规则所需
        /// </summary>
        public DateTime? mImageFileDateTime { get; set; }

        /// <summary>
        /// 静默模式 (默认开启)
        /// </summary>
        public bool mIsSlient { get; set; } = true;

        public void SetIsSilent(bool v)
        {
            mIsSlient = v;
        }

        #region 开始录制

        /// <summary>
        /// 开始屏幕录制
        /// </summary>
        /// <param name="imageFileDateTime">时间参数 - 屏幕截图文件名命名规则所需</param>
        /// <param name="dirName">屏幕截图保存文件夹名称</param>
        public FileInfo StartRecord(DateTime? imageFileDateTime = null, string dirName = "")
        {
            if (s_IsRunning.Get() == true)
            {
                string msg = "正在进行录屏, 无法再多开一个";
                System.Diagnostics.Debug.WriteLine(msg);
                showToast(msg);
                return null;
            }

            s_IsRunning.Set(true);

            mImageFileDateTime = imageFileDateTime;
            mDirName = dirName;

            Android.Content.Intent intent = mProjectionManager.CreateScreenCaptureIntent();
            mAppActivity.StartActivityForResult(intent, s_ScreenRecord_Request_Code);

            return MyAndroidScreenRecord.GetScreenVideoFileInfo(mImageFileDateTime, dirName);
        }

        /// <summary>
        /// 开始屏幕录制
        /// </summary>
        public void StartRecord_ActualMethod(Android.App.Result resultCode, Android.Content.Intent data)
        {
            string msg = string.Empty;
            if (resultCode != Android.App.Result.Ok) // 用户拒绝授权
            {
                s_IsRunning.Set(false);

                msg = "用户已拒绝授权，录制屏幕停止执行。";
                System.Diagnostics.Debug.WriteLine(msg);
                showToast(msg);

                return;
            }

            // System.Threading.Thread.Sleep(500); // 以防截取到授权窗口，停顿 500 ms
            System.Threading.Thread.Sleep(1000);

            mProjection = mProjectionManager.GetMediaProjection((int)resultCode, data); // ok = -1

            Android.Util.DisplayMetrics displayMetrics = new Android.Util.DisplayMetrics();
            mAppActivity.WindowManager.DefaultDisplay.GetRealMetrics(displayMetrics);
            int width = displayMetrics.WidthPixels;
            int height = displayMetrics.HeightPixels;

            initRecorder(width, height);
            mDisplay = mProjection.CreateVirtualDisplay
            (
                name: "MyAndroidScreenRecord",
                width: width,
                height: height,
                dpi: (int)Android.Util.DisplayMetricsDensity.Medium, // TODO Dpi

                // DisplayManager.VIRTUAL_DISPLAY_FLAG_AUTO_MIRROR, // TODO Xamarin.Android 中没有此参数
                flags: Android.Views.DisplayFlags.Presentation,

                surface: mMediaRecorder.Surface,
                callback: null,
                handler: null
            );

            msg = "屏幕录像开始";
            System.Diagnostics.Debug.WriteLine(msg);
            // showToast(msg); // 不显示开始信息, 更好地进行录像

            //Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
            //{
                mMediaRecorder.Start();
            //});
        }

        private void initRecorder(int width, int height)
        {
            mMediaRecorder = new Android.Media.MediaRecorder();

            // 遇到的坑 -- 用户权限没有赋予 Mic 会报错 "setAudioSource failed.", 故此处进行判断是否含有麦克风权限
            if (Xamarin.Essentials.DeviceInfo.Version.Major >= 6)
            {
                Android.Content.PM.Permission permission = mAppActivity.CheckSelfPermission(Android.Manifest.Permission.RecordAudio);
                if (permission == Android.Content.PM.Permission.Granted)
                {
                    // mediaRecorder.setAudioSource(MediaRecorder.AudioSource.MIC);
                    mMediaRecorder.SetAudioSource(Android.Media.AudioSource.Mic);
                }
            }

            // mediaRecorder.setVideoSource(MediaRecorder.VideoSource.SURFACE);
            mMediaRecorder.SetVideoSource(Android.Media.VideoSource.Surface);

            // mediaRecorder.setOutputFormat(MediaRecorder.OutputFormat.THREE_GPP);
            mMediaRecorder.SetOutputFormat(Android.Media.OutputFormat.ThreeGpp);

            // mediaRecorder.setOutputFile(getsaveDirectory() + System.currentTimeMillis() + ".mp4");
            // 遇到的坑 -- 目录没有创建会报出 Java.IO.FileNotFoundException, 要先判断 Dir 是否存在, 不存在则进行创建
            var mp4FileInfo = MyAndroidScreenRecord.GetScreenVideoFileInfo(mImageFileDateTime, mDirName);
            if (mp4FileInfo.Directory.Exists == false)
            {
                mp4FileInfo.Directory.Create();
            }

            mMediaRecorder.SetOutputFile(mp4FileInfo.FullName);

            // mediaRecorder.setVideoSize(width, height);            
            mMediaRecorder.SetVideoSize(width, height);

            // mediaRecorder.setVideoEncoder(MediaRecorder.VideoEncoder.H264);
            mMediaRecorder.SetVideoEncoder(Android.Media.VideoEncoder.H264);

            // 遇到的坑 -- 用户权限没有赋予 Mic 会报错 "setAudioSource failed.", 故此处进行判断是否含有麦克风权限
            if (Xamarin.Essentials.DeviceInfo.Version.Major >= 6)
            {
                Android.Content.PM.Permission permission = mAppActivity.CheckSelfPermission(Android.Manifest.Permission.RecordAudio);
                if (permission == Android.Content.PM.Permission.Granted)
                {
                    // mediaRecorder.setAudioEncoder(MediaRecorder.AudioEncoder.AMR_NB);
                    mMediaRecorder.SetAudioEncoder(Android.Media.AudioEncoder.AmrNb);
                }
            }

            // mediaRecorder.setVideoEncodingBitRate(5 * 1024 * 1024);
            mMediaRecorder.SetVideoEncodingBitRate(5 * 1024 * 1024);

            // mediaRecorder.setVideoFrameRate(30);
            mMediaRecorder.SetVideoFrameRate(mDpi);

            try
            {
                mMediaRecorder.Prepare();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("MyAndroidScreenRecord - initRecorder 捕获到错误");
                System.Diagnostics.Debug.WriteLine(ex.GetFullInfo());
                System.Diagnostics.Debugger.Break();

                throw ex;
            }
        }

        #endregion

        #region 停止录制

        public void StopRecord()
        {
            if (mMediaRecorder != null)
            {
                mMediaRecorder.Stop();
                // mMediaRecorder.Reset();
                mMediaRecorder.Release();
                mMediaRecorder = null;
            }

            if (mDisplay != null)
            {
                mDisplay.Release();
                mDisplay = null;
            }

            if (mProjection != null)
            {
                mProjection.Stop();
                mProjection = null;
            }

            s_IsRunning.Set(false);

            string msg = "停止屏幕录像";
            System.Diagnostics.Debug.WriteLine(msg);
            showToast(msg);
        }

        #endregion

        #region 实现接口方法 - Get_ScreenshotFileInfo

        public FileInfo Get_ScreenVideoFileInfo(DateTime? imageFileDateTime = null, string dirName = "")
        {
            return MyAndroidScreenRecord.GetScreenVideoFileInfo(imageFileDateTime, dirName);
        }

        #endregion

        private void showToast(string msg)
        {
            if (mIsSlient == false)
            {
                Android.Widget.Toast.MakeText(mAppActivity.ApplicationContext, msg, Android.Widget.ToastLength.Short).Show();
            }
        }

    }
}