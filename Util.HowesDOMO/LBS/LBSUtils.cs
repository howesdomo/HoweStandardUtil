using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/// <summary>
/// V 1 -- 2019-05-06 11:17:48
/// 首次创建 Util.LBS.LBSUtils.cs, 用于解决不同地图中, 测量坐标体系的转换
/// 
/// V2 -- 2019-05-06 18:00:43
/// 待完成中国地图电子围栏
/// 
/// V3 -- 2020-11-3 14:13:19
/// 增加两点间距离计算方法
/// </summary>
namespace Util.LBS
{
    public class LBSUtils
    {
        private static double pi = 3.1415926535897932384626;
        private static double a = 6378245.0;
        private static double ee = 0.00669342162296594323;
        private static double bd_pi = 3.14159265358979324 * 3000.0 / 180.0;

        static double transformLat(double x, double y)
        {
            double ret = -100.0 + 2.0 * x + 3.0 * y + 0.2 * y * y + 0.1 * x * y + 0.2 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(y * pi) + 40.0 * Math.Sin(y / 3.0 * pi)) * 2.0 / 3.0;
            ret += (160.0 * Math.Sin(y / 12.0 * pi) + 320 * Math.Sin(y * pi / 30.0)) * 2.0 / 3.0;
            return ret;
        }

        static double transformLon(double x, double y)
        {
            double ret = 300.0 + x + 2.0 * y + 0.1 * x * x + 0.1 * x * y + 0.1 * Math.Sqrt(Math.Abs(x));
            ret += (20.0 * Math.Sin(6.0 * x * pi) + 20.0 * Math.Sin(2.0 * x * pi)) * 2.0 / 3.0;
            ret += (20.0 * Math.Sin(x * pi) + 40.0 * Math.Sin(x / 3.0 * pi)) * 2.0 / 3.0;
            ret += (150.0 * Math.Sin(x / 12.0 * pi) + 300.0 * Math.Sin(x / 30.0
                    * pi)) * 2.0 / 3.0;
            return ret;
        }

        public static LBSPoint WGS_84_To_GCJ_02(LBSPoint args)
        {
            double dLat = transformLat(args.Lng - 105.0, args.Lat - 35.0);
            double dLon = transformLon(args.Lng - 105.0, args.Lat - 35.0);
            double radLat = args.Lat / 180.0 * pi;
            double magic = Math.Sin(radLat);
            magic = 1 - ee * magic * magic;
            double sqrtMagic = Math.Sqrt(magic);
            dLat = (dLat * 180.0) / ((a * (1 - ee)) / (magic * sqrtMagic) * pi);
            dLon = (dLon * 180.0) / (a / sqrtMagic * Math.Cos(radLat) * pi);
            double mgLat = args.Lat + dLat;
            double mgLon = args.Lng + dLon;
            return new LBSPoint(mgLat, mgLon, LocationType.GCJ_02);
        }

        static LBSPoint transform(LBSPoint args)
        {
            double dLat = transformLat(args.Lng - 105.0, args.Lat - 35.0);
            double dLon = transformLon(args.Lng - 105.0, args.Lat - 35.0);
            double radLat = args.Lat / 180.0 * pi;
            double magic = Math.Sin(radLat);
            magic = 1 - ee * magic * magic;
            double sqrtMagic = Math.Sqrt(magic);
            dLat = (dLat * 180.0) / ((a * (1 - ee)) / (magic * sqrtMagic) * pi);
            dLon = (dLon * 180.0) / (a / sqrtMagic * Math.Cos(radLat) * pi);
            double mgLat = args.Lat + dLat;
            double mgLon = args.Lng + dLon;

            return new LBSPoint(mgLat, mgLon);
        }

        public static LBSPoint GCJ_02_To_WGS_84(LBSPoint args_GCJ_02)
        {
            LBSPoint gps = transform(args_GCJ_02);
            double lontitude = args_GCJ_02.Lng * 2 - gps.Lng;
            double latitude = args_GCJ_02.Lat * 2 - gps.Lat;
            return new LBSPoint(latitude, lontitude, LocationType.WGS_84);
        }

        public static LBSPoint GCJ_02_To_BD_09(LBSPoint args_GCJ_02)
        {
            double x = args_GCJ_02.Lng;
            double y = args_GCJ_02.Lat;
            double z = Math.Sqrt(x * x + y * y) + 0.00002 * Math.Sin(y * bd_pi);
            double theta = Math.Atan2(y, x) + 0.000003 * Math.Cos(x * bd_pi);
            double bd_lon = z * Math.Cos(theta) + 0.0065;
            double bd_lat = z * Math.Sin(theta) + 0.006;
            return new LBSPoint(bd_lat, bd_lon, LocationType.BD_09);
        }

        public static LBSPoint BD_09_To_GCJ_02(LBSPoint args_BD_09)
        {
            double x = args_BD_09.Lng - 0.0065;
            double y = args_BD_09.Lat - 0.006;
            double z = Math.Sqrt(x * x + y * y) - 0.00002 * Math.Sin(y * bd_pi);
            double theta = Math.Atan2(y, x) - 0.000003 * Math.Cos(x * bd_pi);
            double gg_lon = z * Math.Cos(theta);
            double gg_lat = z * Math.Sin(theta);
            return new LBSPoint(gg_lat, gg_lon, LocationType.GCJ_02);
        }

        public static LBSPoint BD_09_To_WGS_84(LBSPoint args_BD_09)
        {
            LBSPoint gcj_02 = BD_09_To_GCJ_02(args_BD_09);
            LBSPoint wgs_84 = GCJ_02_To_WGS_84(gcj_02);
            return wgs_84;

        }

        public static LBSPoint WGS_84_To_BD_09(LBSPoint args_WGS_84)
        {
            LBSPoint gcj_02 = WGS_84_To_GCJ_02(args_WGS_84);
            LBSPoint bd_09 = GCJ_02_To_BD_09(gcj_02);
            return bd_09;

        }

        #region 围栏计算

        /// <summary>
        /// 围栏计算(点是否在围栏内)
        /// </summary>
        /// <param name="latlon">单点坐标</param>
        /// <param name="APoints">坐标集合</param>
        /// <returns></returns>
        public static bool MBR(Util.LBS.LBSPoint point, List<Util.LBS.LBSPoint> pointRange)
        {
            if (pointRange == null || pointRange.Count < 3)
            {
                throw new ArgumentException("集合 pointRange 的长度不足3, 无法计算");
            }

            if (false == (pointRange.Count == pointRange.Where(i => i.LocationType == point.LocationType).Count()))
            {
                throw new ArgumentException("传入参数的属性 LocationType 不一致");
            }

            if (isSimpleMatch(point, pointRange)) // 先用最小外包法判断
            {
                // 符合最小外包法判断后用暴力遍历法细致判断
                return isPointInPolygon(point, pointRange);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 最小外包法
        /// </summary>
        /// <param name="point"></param>
        /// <param name="pointRange"></param>
        /// <returns></returns>
        private static bool isSimpleMatch(Util.LBS.LBSPoint point, List<Util.LBS.LBSPoint> pointRange)
        {
            double max_lng = pointRange.Max(x => x.Lng);
            double max_lat = pointRange.Max(x => x.Lat);

            double min_lon = pointRange.Min(x => x.Lng);
            double min_lat = pointRange.Min(x => x.Lat);

            double aLng = point.Lng;
            double aLat = point.Lat;

            if (aLng >= max_lng || aLng <= min_lon || aLat >= max_lat || aLat <= min_lat)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 判断点在围栏内（暴力遍历法）
        /// <para>
        /// 计算原理
        /// </para>
        /// <para>
        /// 地理围栏一般是多边形，判断点在多边形内部可以通过射线法来判断点是否在多边形内部。从一点出发沿着X轴画一条射线，依次判断该射线与每条边的交点，并统计交点个数，如果交点数为奇数，则在多边形内部，如果焦点数是偶数，则在外部，射线法对凸和非凸多边形都适用，复杂度为O(N)，其它N是边数。
        /// 当地理围栏多边形数目较少时，我们可以依次遍历每一个多边形（暴力遍历法），然后用射线法进行判断，这样效率也很高。而当多边形数目较多时，比如有10万个多边形，这个时候需要执行10万次射线法，响应时间达到3.9秒。
        /// </para>
        /// </summary>
        /// <param name="point"></param>
        /// <param name="pointRange"></param>
        /// <returns></returns>
        private static bool isPointInPolygon(Util.LBS.LBSPoint point, List<Util.LBS.LBSPoint> pointRange)
        {
            int iSum = 0, iCount;
            double dLng1, dLng2, dLat1, dLat2, dLng;
            double ALat = point.Lat;
            double ALon = point.Lng;

            if (pointRange.Count < 3)
            {
                return false;
            }

            iCount = pointRange.Count;

            for (int i = 0; i < iCount; i++)
            {
                if (i == iCount - 1)
                {
                    dLng1 = pointRange[i].Lng;
                    dLat1 = pointRange[i].Lat;
                    dLng2 = pointRange[0].Lng;
                    dLat2 = pointRange[0].Lat;
                }
                else
                {
                    dLng1 = pointRange[i].Lng;
                    dLat1 = pointRange[i].Lat;
                    dLng2 = pointRange[i + 1].Lng;
                    dLat2 = pointRange[i + 1].Lat;
                }

                //以下语句判断A点是否在边的两端点的水平平行线之间，在则可能有交点，开始判断交点是否在左射线上
                if (((ALat >= dLat1) && (ALat < dLat2)) || ((ALat >= dLat2) && (ALat < dLat1)))
                {
                    if (Math.Abs(dLat1 - dLat2) > 0)
                    {
                        //得到 A点向左射线与边的交点的x坐标：
                        dLng = dLng1 - ((dLng1 - dLng2) * (dLat1 - ALat)) / (dLat1 - dLat2);

                        // 如果交点在A点左侧（说明是做射线与 边的交点），则射线与边的全部交点数加一：
                        if (dLng < ALon)
                        {
                            iSum++;
                        }
                    }
                }
            }

            if (iSum % 2 != 0)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region 中国境内地理围栏

        public static bool IsOutOfChina(LBSInfo lbsInfo)
        {
            return !MBR(lbsInfo.WGS_84, WGS_84RangeOfChina);
        }

        /// <summary>
        /// 中国境内地理围栏
        /// </summary>
        private static List<Util.LBS.LBSPoint> WGS_84RangeOfChina = new List<LBSPoint>()
        {
            new LBSPoint(lng: 123.15668, lat:53.87982, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 127.44135, lat:52.69778, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 128.67182, lat:49.85366, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 135.13178, lat:48.60541, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 133.59369, lat:44.60778, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 131.39643, lat:42.63569, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 121.99213, lat:38.49843, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 123.66205, lat:37.00443, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 123.67903, lat:21.62132, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 117.79035, lat:20.91489, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 117.64154, lat:14.20276, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 111.40131, lat:13.43465, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 107.49283, lat:19.16804, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 107.70157, lat:21.43471, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 105.30271, lat:23.11538, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 101.57834, lat:21.05916, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 99.0726, lat:22.11164, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 97.03119, lat:24.26914, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 98.21771, lat:27.54932, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 92.7804, lat:26.94102, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 88.92179, lat:27.31304, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 78.17641, lat:31.33941, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 78.18580, lat:32.60265, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 78.43227, lat:34.21159, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 74.35381, lat:37.02668, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 73.45553, lat:39.45471, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 79.9396, lat:42.29008, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 79.8423, lat:45.05689, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 87.53009, lat:49.32554, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 91.42816, lat:46.27266, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 95.60297, lat:44.35696, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 96.63501, lat:42.93401, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 111.76318, lat:43.67086, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 111.79112, lat:45.23349, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 119.73423, lat:46.85754, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 115.11469, lat:48.12367, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 116.82704, lat:49.89767, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 120.61733, lat:52.26965, locType: LocationType.WGS_84 ),
            new LBSPoint(lng: 119.68349, lat:52.92362, locType: LocationType.WGS_84 ),
        };

        #endregion

        #region 两点间距离计算

        /// <summary>
        ///计算两点GPS坐标的距离
        /// </summary>
        /// <param name="n1">第一点的纬度坐标</param>
        /// <param name="e1">第一点的经度坐标</param>
        /// <param name="n2">第二点的纬度坐标</param>
        /// <param name="e2">第二点的经度坐标</param>
        /// <returns></returns>
        public static double Distance(double p1_WeiDu, double p1_JingDu, double p2_WeiDu, double p2_JingDu)
        {
            return LBS.LBSUtils.Distance(new LBSPoint(p1_WeiDu, p1_JingDu), new LBSPoint(p2_WeiDu, p2_JingDu));
        }

        /// <summary>
        ///计算两点GPS坐标的距离
        /// </summary>
        /// <param name="n1">第一点的纬度坐标</param>
        /// <param name="e1">第一点的经度坐标</param>
        /// <returns></returns>
        public static double Distance(LBS.LBSPoint p1, LBS.LBSPoint p2)
        {
            if (p1.LocationType != p2.LocationType)
            {
                throw new Exception("坐标体系不一致, 请先进行转换");
            }

            double jl_lng = 102834.74258026089786013677476285;
            double jl_lat = 111712.69150641055729984301412873;
            double b = Math.Abs((p1.Lng - p2.Lng) * jl_lng);
            double a = Math.Abs((p1.Lat - p2.Lat) * jl_lat);
            return Math.Sqrt((a * a + b * b));
        }

        #endregion
    }
}
