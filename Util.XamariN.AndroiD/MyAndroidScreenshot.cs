using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.XamariN.AndroiD
{
    /// <summary>
    /// V 1.0.1 - 2020-06-11 13:50:58
    /// 增加接口逻辑, 使 Client 端更方便地使用
    /// 
    /// V 1.0.0 - 2020-06-09 18:51:40
    /// 首次创建
    /// </summary>
    public class MyAndroidScreenshot : Util.XamariN.IAndroidScreenshot
    {
        public const int s_Screenshot_Request_Code = 3105; // shot

        // private static readonly object _LOCK_ = new object();

        // public static System.Threading.AutoResetEvent s_OneScreenshot = new System.Threading.AutoResetEvent(false);

        public static Java.Util.Concurrent.Atomic.AtomicBoolean s_IsRunning = new Java.Util.Concurrent.Atomic.AtomicBoolean(false);

        public static System.IO.FileInfo GetScreenshotFileInfo(DateTime? dt = null, string dirPath = "")
        {
            if (dt.HasValue == false)
            {
                dt = DateTime.Now;
            }

            if (dirPath.IsNullOrWhiteSpace() == true)
            {
                dirPath = "Screenshots";
            }

            Java.IO.File childFolder = Android.App.Application.Context.GetExternalFilesDir("/");

            string exceptionScreenshotsDir = System.IO.Path.Combine(childFolder.AbsolutePath, dirPath);

            string filePath = System.IO.Path.Combine(exceptionScreenshotsDir, $"{dt.Value.ToString("yyyyMMdd_HHmmssfffffff")}.png");

            return new System.IO.FileInfo(filePath);
        }


        // =========================== End 静态对象与方法 ===========================


        private Android.App.Activity mAppActivity { get; set; }

        #region 构造函数 + 单例模式

        private MyAndroidScreenshot(Android.App.Activity activity)
        {
            mAppActivity = activity;

            if (mProjectionManager == null)
            {
                mProjectionManager = (Android.Media.Projection.MediaProjectionManager)mAppActivity.GetSystemService(Android.Content.Context.MediaProjectionService);
            }
        }

        private static MyAndroidScreenshot s_Instance;

        private static object objLock = new object();

        public static MyAndroidScreenshot GetInstance(Android.App.Activity activity = null)
        {
            lock (objLock)
            {
                if (s_Instance == null)
                {
                    if (activity == null)
                    {
                        throw new Exception("MyScreenCapture.GetInstance 单例首次创建, 请传入 activity 参数");
                    }

                    s_Instance = new MyAndroidScreenshot(activity);
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

        public Android.Media.ImageReader mImageReader
        {
            get;
            private set;
        }

        public Android.Hardware.Display.VirtualDisplay mDisplay
        {
            get;
            private set;
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

        #region 实现接口方法 - OnScreenshot

        /// <summary>
        /// 开始截屏
        /// </summary>
        /// <param name="imageFileDateTime">时间参数 - 屏幕截图文件名命名规则所需</param>
        /// <param name="dirName">屏幕截图保存文件夹名称</param>
        public void OnScreenshot(DateTime? imageFileDateTime, string dirName = "")
        {
            if (s_IsRunning.Get() == true)
            {
                string msg = "正在进行截屏, 无法再多开一个";
                System.Diagnostics.Debug.WriteLine(msg);
                showToast(msg);
                return;
            }

            s_IsRunning.Set(true);

            mImageFileDateTime = imageFileDateTime;
            mDirName = dirName;

            Android.Content.Intent intent = mProjectionManager.CreateScreenCaptureIntent();
            mAppActivity.StartActivityForResult(intent, s_Screenshot_Request_Code);
        }

        public void Screenshot_ActualMethod(Android.App.Result resultCode, Android.Content.Intent data)
        {
            string msg = string.Empty;
            if (resultCode != Android.App.Result.Ok) // 用户拒绝授权
            {
                s_IsRunning.Set(false);
                msg = "用户已拒绝授权，屏幕截图停止执行。";
                System.Diagnostics.Debug.WriteLine(msg);
                showToast(msg);
                return;
            }

            // System.Threading.Thread.Sleep(500); // 以防截取到授权窗口，停顿 500 ms
            System.Threading.Thread.Sleep(1000); // 以防截取到授权窗口，停顿 500 ms

            mProjection = mProjectionManager.GetMediaProjection((int)resultCode, data); // ok = -1

            Android.Util.DisplayMetrics displayMetrics = new Android.Util.DisplayMetrics();
            mAppActivity.WindowManager.DefaultDisplay.GetRealMetrics(displayMetrics);
            int width = displayMetrics.WidthPixels;
            int height = displayMetrics.HeightPixels;

            if (mImageReader != null)
            {
                mImageReader.Close();
                mImageReader = null;
            }

            if (mDisplay != null)
            {
                mDisplay.Release();
                mDisplay = null;
            }

            mImageReader = Android.Media.ImageReader.NewInstance
            (
                width: width,
                height: height,
                // Bitmap.Config.ARGB_8888 // Android 源码传入参数
                // format: Android.Graphics.ImageFormatType.FlexRgba8888, // 由于没有 Config.ARGB_8888, 故从 AndroidStudio 中获取 Config.ARGB_8888 枚举的值 ( = 1 )
                format: (Android.Graphics.ImageFormatType)1, // Bitmap.Config.ARGB_8888
                maxImages: 2
            );

            mDisplay = mProjection.CreateVirtualDisplay
            (
                name: "MyAndroidScreenshot",
                width: width,
                height: height,
                dpi: (int)Android.Util.DisplayMetricsDensity.Medium,
                flags: Android.Views.DisplayFlags.Presentation,
                surface: mImageReader.Surface,
                callback: null,
                handler: null
            );

            var listener = new MyScreenshotListener
            (
                width: width,
                height: height,
                imageFileDateTime: mImageFileDateTime,
                dirName: mDirName
            );

            mImageReader.SetOnImageAvailableListener(listener: listener, handler: getBackgroundHandler());

            msg = "屏幕截图开始";
            System.Diagnostics.Debug.WriteLine(msg);
            // showToast(msg); // 不显示开始信息, 更好地进行截图
        }

        

        public void ReleaseAfterScreenCaptureSave()
        {
            mImageReader.SetOnImageAvailableListener(null, null);

            if (mDisplay != null)
            {
                mDisplay.Release();
                mDisplay = null;
            }

            if (mImageReader != null)
            {
                mImageReader.Close();
                mImageReader = null;
            }

            if (mProjection != null)
            {
                mProjection.Stop();
                mProjection = null;
            }

            string msg = "屏幕截图结束";
            System.Diagnostics.Debug.WriteLine(msg);
            showToast(msg);
        }

        /// <summary>
        /// 在后台线程里保存文件
        /// </summary>
        private Android.OS.Handler mBackgroundHandler { get; set; }

        private Android.OS.Handler getBackgroundHandler()
        {
            if (mBackgroundHandler == null)
            {
                Android.OS.HandlerThread backgroundThread = new Android.OS.HandlerThread("catwindow", (int)Android.OS.ThreadPriority.Background);
                backgroundThread.Start();
                mBackgroundHandler = new Android.OS.Handler(backgroundThread.Looper);
            }

            return mBackgroundHandler;
        }

        public void OnScreenshot()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 实现接口方法 - OnScreenshotFromActivity

        public void OnScreenshotFromActivity(DateTime? imageFileDateTime = null, string dirName = "")
        {
            mImageFileDateTime = imageFileDateTime;
            mDirName = dirName;

            // View view = ctx.getWindow().getDecorView();
            var view = mAppActivity.Window.DecorView;

            // view.setDrawingCacheEnabled(true);
            view.DrawingCacheEnabled = true;

            // view.buildDrawingCache();
            view.BuildDrawingCache();

            Android.Graphics.Bitmap bp = Android.Graphics.Bitmap.CreateBitmap
            (
                view.DrawingCache,
                0,
                0,
                view.MeasuredWidth,
                view.MeasuredHeight
            );

            // view.setDrawingCacheEnabled(false);
            view.DrawingCacheEnabled = false;

            // view.destroyDrawingCache();
            view.DestroyDrawingCache();


            var imagefileInfo = MyAndroidScreenshot.GetScreenshotFileInfo(mImageFileDateTime, mDirName); // 传入目录名称

            if (imagefileInfo.Directory.Exists == false)
            {
                imagefileInfo.Directory.Create();
            }

            string imageFile = imagefileInfo.FullName;

            using (System.IO.FileStream stream = new System.IO.FileStream(path: imageFile, System.IO.FileMode.CreateNew))
            {
                bp.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 60, stream); // 压缩图片 // TODO 控制图片质量
                stream.Flush();
            }

            // 发送广播                        
            Android.App.Application.Context.SendBroadcast
            (
                new Android.Content.Intent
                (
                    action: Android.Content.Intent.ActionMediaScannerScanFile,
                    uri: Android.Net.Uri.FromFile(new Java.IO.File(imageFile))
                )
            );

            string msg = "成功保存屏幕截图";
            System.Diagnostics.Debug.WriteLine(msg);
            showToast(msg);
        }

        #endregion

        #region 实现接口方法 - Get_ScreenshotFileInfo

        public System.IO.FileInfo Get_ScreenshotFileInfo(DateTime? imageFileDateTime = null, string dirName = "")
        {
            return MyAndroidScreenshot.GetScreenshotFileInfo(imageFileDateTime, dirName);
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

    /// <summary>
    /// V 1.0.0 - 首次创建
    /// </summary>
    public class MyScreenshotListener : Java.Lang.Object, Android.Media.ImageReader.IOnImageAvailableListener
    {
        /// <summary>
        /// 屏幕 Width
        /// </summary>
        public int mWidth;

        /// <summary>
        /// 屏幕 Height
        /// </summary>
        public int mHeight;

        /// <summary>
        /// 屏幕截图保存文件夹名称
        /// </summary>
        public string mDirName { get; set; }

        /// <summary>
        /// 时间参数 - 屏幕截图文件名命名规则所需
        /// </summary>
        public DateTime? mImageFileDateTime { get; set; }

        /// <summary>
        /// 屏幕截图监听器构造函数
        /// </summary>
        /// <param name="width">屏幕 Width</param>
        /// <param name="height">屏幕 Height</param>
        /// <param name="imageFileDateTime">时间参数 - 屏幕截图文件名命名规则所需</param>
        /// <param name="dirName">屏幕截图保存文件夹名称</param>
        public MyScreenshotListener(int width, int height, DateTime? imageFileDateTime = null, string dirName = "")
        {
            this.mWidth = width;
            this.mHeight = height;
            this.mDirName = dirName;
            this.mImageFileDateTime = imageFileDateTime;
        }

        public void OnImageAvailable(Android.Media.ImageReader imageReader)
        {
            Android.Media.Image image = null;
            Android.Graphics.Bitmap bitmapFromPlane0 = null;
            Android.Graphics.Bitmap bitmapToSave = null;

            try
            {
                image = imageReader.AcquireLatestImage();

                if (image != null)
                {
                    Android.Media.Image.Plane[] planes = image.GetPlanes();
                    if (planes.Length > 0)
                    {
                        int rowPadding = planes[0].RowStride - planes[0].PixelStride * mWidth;

                        bitmapFromPlane0 = Android.Graphics.Bitmap.CreateBitmap
                        (
                            width: (mWidth + rowPadding / planes[0].PixelStride), // 此处不能直接采用 Width, 否则保存的图片会出现花屏
                            height: mHeight,
                            config: Android.Graphics.Bitmap.Config.Argb8888
                        );

                        bitmapFromPlane0.CopyPixelsFromBuffer(planes[0].Buffer);

                        var imagefileInfo = MyAndroidScreenshot.GetScreenshotFileInfo(mImageFileDateTime, mDirName); // 传入目录名称

                        if (imagefileInfo.Directory.Exists == false)
                        {
                            imagefileInfo.Directory.Create();
                        }

                        string imageFile = imagefileInfo.FullName;

                        // bitmapFromPlane0 多增加的长度减至 屏幕的 Width
                        bitmapToSave = Android.Graphics.Bitmap.CreateBitmap(bitmapFromPlane0, 0, 0, mWidth, mHeight);

                        using (System.IO.FileStream stream = new System.IO.FileStream(path: imageFile, System.IO.FileMode.CreateNew))
                        {
                            bitmapToSave.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 60, stream); // 压缩图片 // TODO 控制图片质量
                            stream.Flush();
                        }

                        // 发送广播                        
                        Android.App.Application.Context.SendBroadcast
                        (
                            new Android.Content.Intent
                            (
                                action: Android.Content.Intent.ActionMediaScannerScanFile,
                                uri: Android.Net.Uri.FromFile(new Java.IO.File(imageFile))
                            )
                        );

                        System.Diagnostics.Debug.WriteLine("MyImageReaderListener-OnImageAvailable - 成功保存屏幕截图");
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("MyImageReaderListener-OnImageAvailable - 捕获异常");
                System.Diagnostics.Debug.WriteLine(e.GetFullInfo());
                System.Diagnostics.Debugger.Break();
            }
            finally
            {
                if (bitmapFromPlane0 != null)
                {
                    bitmapFromPlane0.Recycle();
                    bitmapFromPlane0 = null;
                }

                if (image != null)
                {
                    image.Close();
                    image = null;
                }

                MyAndroidScreenshot.GetInstance().ReleaseAfterScreenCaptureSave();

                MyAndroidScreenshot.s_IsRunning.Set(false);
            }
        }
    }



    // 知识点 1 MediaProjection ( Added in API level 21 )
    // https://developer.android.com/reference/android/media/projection/MediaProjection
    // A token granting applications the ability to capture screen contents and/or record system audio. The exact capabilities granted depend on the type of MediaProjection.
    // A screen capture session can be started through MediaProjectionManager#createScreenCaptureIntent. This grants the ability to capture screen contents, but not system audio.



    // 知识点 2
    // 需要权限 android.permission.RECORD_AUDIO

    // Android 6.0 加入的动态权限申请，如果应用的 targetSdkVersion 是 23，申请敏感权限还需要动态申请

    // if (ContextCompat.checkSelfPermission(MainActivity.this, Manifest.permission.WRITE_EXTERNAL_STORAGE)
    //    != PackageManager.PERMISSION_GRANTED) {
    //        ActivityCompat.requestPermissions(this, new String[] { Manifest.permission.WRITE_EXTERNAL_STORAGE }, STORAGE_REQUEST_CODE);
    //    }
    // if (ContextCompat.checkSelfPermission(MainActivity.this, Manifest.permission.RECORD_AUDIO)
    //    != PackageManager.PERMISSION_GRANTED) {
    //        ActivityCompat.requestPermissions(this, new String[] { Manifest.permission.RECORD_AUDIO }, AUDIO_REQUEST_CODE);
    //    }
}