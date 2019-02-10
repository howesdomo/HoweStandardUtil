//// 暂时无法在 iOS 项目中正确地找到这里的 DependencyService 具体实现代码

//// Step 1 加上 using Xamarin.Forms;
//using Xamarin.Forms;

//// Step 2 加上 [assembly: Dependency(typeof(CoreUtil.XamariN.Essentials.DisplayInfoUtils))]
//[assembly: Dependency(typeof(Util.XamariN.Essentials.DisplayInfoUtils))]
//namespace Util.XamariN.Essentials
//{
//    public class DisplayInfoUtils : IDisplayInfoUtils
//    {
//        public DisplayInfoUtils()
//        {

//        }

//        /// <summary>
//        /// 实现接口方法
//        /// </summary>
//        /// <returns></returns>
//        public DisplayInfo GetDisplayInfo()
//        {
//            // Get Metrics
//            // var metrics = Xamarin.Essentials.DeviceDisplay.ScreenMetrics; // 0.1.0 preview
//            var metrics = Xamarin.Essentials.DeviceDisplay.MainDisplayInfo; // 1.0.2

//            //// Orientation (Landscape, Portrait, Square, Unknown)
//            //var orientation = metrics.Orientation;

//            //// Rotation (0, 90, 180, 270)
//            //var rotation = metrics.Rotation;

//            //// Width (in pixels)
//            //var width = metrics.Width;

//            //// Height (in pixels)
//            //var height = metrics.Height;

//            //// Screen density
//            //var density = metrics.Density;

//            return new DisplayInfo()
//            {
//                Orientation = metrics.Orientation.ToString(),
//                RotationInfo = metrics.Rotation.ToString(),
//                Rotation = int.Parse(metrics.Rotation.ToString().ToUpper().Replace("ROTATION", "")),
//                Width = metrics.Width,
//                Height = metrics.Height,
//                Density = metrics.Density
//            };

//        }
//    }
//}
