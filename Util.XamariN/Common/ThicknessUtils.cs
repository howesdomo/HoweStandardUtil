using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Util.XamariN.Common
{
    /// <summary>
    /// V 1.0.0 - 2020-1-9 14:46:03
    /// 首次创建
    /// </summary>
    public class ThicknessUtils
    {
        public static Thickness CalcThickness(object newValue)
        {
            string args = newValue.ToString();
            string[] t = newValue.ToString()
                                 .Split(',')
                                 .Select(i => i.Trim())
                                 .ToArray();

            double left = 0;
            double top = 0;
            double right = 0;
            double bottom = 0;

            switch (t.Count())
            {
                case 1:
                    left = Double.Parse(t[0]);
                    top = Double.Parse(t[0]);
                    right = Double.Parse(t[0]);
                    bottom = Double.Parse(t[0]);
                    break;

                case 2:
                    left = Double.Parse(t[0]);
                    top = Double.Parse(t[1]);
                    right = Double.Parse(t[0]);
                    bottom = Double.Parse(t[1]);
                    break;

                case 4:
                    left = Double.Parse(t[0]);
                    top = Double.Parse(t[1]);
                    right = Double.Parse(t[2]);
                    bottom = Double.Parse(t[3]);
                    break;

                default:
                    throw new Exception($"设置Margin参数异常。异常参数{args}");
            }

            return new Thickness(left, top, right, bottom);
        }
    }
}
