using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.LBS
{
    /// <summary>
    /// 基于移动位置服务( Location Based Service )
    /// </summary>
    public class LBSPoint
    {
        /// <summary>
        /// 纬度
        /// </summary>
        public double Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Lng { get; set; }

        public LocationType LocationType { get; set; }

        /// <summary>
        /// 不在中国境内
        /// </summary>
        public bool IsOutOfChina { get; set; }

        public LBSPoint(double lat, double lng, LocationType locType = LocationType.GCJ_02)
        {
            this.Lat = lat;
            this.Lng = lng;
            this.LocationType = locType;
        }
    }
}
