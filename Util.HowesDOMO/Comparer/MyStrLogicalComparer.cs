using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util_Comparer
{
    /// <summary>
    /// 仿照 Shlwapi.dll 的方法 StrCmpLogicalW , 编写的比较逻辑
    /// 优点 : 不用依赖 Shlwapi.dll
    /// </summary>
    public class MyStrLogicalComparer : Comparer<object>
    {
        public override int Compare(object x, object y)
        {
            return compare(x.ToString(), y.ToString());
        }

        int compare(string x, string y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            int lx = x.Length, ly = y.Length;

            for (int mx = 0, my = 0; mx < lx && my < ly; mx++, my++)
            {
                if (char.IsDigit(x[mx]) && char.IsDigit(y[my]))
                {
                    long vx = 0, vy = 0;

                    for (; mx < lx && char.IsDigit(x[mx]); mx++)
                        vx = vx * 10 + x[mx] - '0';

                    for (; my < ly && char.IsDigit(y[my]); my++)
                        vy = vy * 10 + y[my] - '0';

                    if (vx != vy)
                        return vx > vy ? 1 : -1;
                }

                if (mx < lx && my < ly && x[mx] != y[my])
                {
                    // Edit By Howe
                    if (x[mx].IsChineseCharacter() && y[my].IsChineseCharacter()) // 两个字符均为中文，则转 Str 后进行比较
                    {
                        // x[mx], y[my] --> 2个 char 进行 CompareTo 并非一定返回 -1, 0, 1
                        // 故将其转为 String 再进行比较
                        string strChar_x = x[mx].ToString();
                        string strChar_y = y[my].ToString();

                        return strChar_x.CompareTo(strChar_y);
                    }
                    // End of Edit
                    else
                    {
                        return x[mx] > y[my] ? 1 : -1;
                    }
                }
            }

            return lx - ly;
        }
    }
}
