﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.LBS
{
    public enum LocationType
    {
        /// <summary>
        /// WGS-84 - 世界大地测量系统
        /// <para>WGS-84（World Geodetic System, WGS）是使用最广泛的坐标系，也是世界通用的坐标系，GPS设备得到的经纬度就是在WGS84坐标系下的经纬度。</para>
        /// <para>通常通过底层接口得到的定位信息都是WGS84坐标系。</para>
        /// </summary>
        WGS_84 = 0,

        /// <summary>
        /// GCJ-02 - 国测局坐标
        /// <para>GCJ-02（G-Guojia国家，C-Cehui测绘，J-Ju局），又被称为火星坐标系，是一种基于WGS-84制定的大地测量系统，由中国国测局制定。此坐标系所采用的混淆算法会在经纬度中加入随机的偏移。</para>
        /// <para>国家规定，中国大陆所有公开地理数据都需要至少用GCJ-02进行加密，也就是说我们从国内公司的产品中得到的数据，一定是经过了加密的。绝大部分国内互联网地图提供商都是使用GCJ-02坐标系，包括高德地图，谷歌地图中国区等。</para>
        /// </summary>
        GCJ_02 = 1,

        /// <summary>
        /// <para>BD-09 - 百度坐标系</para>
        /// <para>BD-09（Baidu, BD）是百度地图使用的地理坐标系，其在GCJ-02上多增加了一次变换，用来保护用户隐私。从百度产品中得到的坐标都是BD-09坐标系。</para>
        /// </summary>
        BD_09 = 2,
    }
}
