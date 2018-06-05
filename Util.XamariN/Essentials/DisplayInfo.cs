using System;
using System.Collections.Generic;
using System.Text;

namespace Util.XamariN.Essentials
{
    public class DisplayInfo
    {
        /// <summary>
        /// Orientation (Landscape, Portrait, Square, Unknown)
        /// </summary>
        public string Orientation { get; set; }

        public string RotationInfo { get; set; }

        /// <summary>
        /// Rotation (0, 90, 180, 270)
        /// </summary>
        public int Rotation { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        /// <summary>
        /// 密度
        /// </summary>
        public double Density { get; set; }

        
    }
}
