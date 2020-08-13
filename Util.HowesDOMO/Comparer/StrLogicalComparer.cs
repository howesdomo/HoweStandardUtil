using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Util_Comparer
{
    /// <summary>
    /// 使用 Shlwapi.dll 的方法 StrCmpLogicalW 进行比较, 
    /// 类似Windows资源管理的文字排序方式
    /// </summary>
    public class StrLogicalComparer : Comparer<object>
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string x, string y);

        public override int Compare(object x, object y)
        {
            return StrCmpLogicalW(x.ToString(), y.ToString());
        }
    }
}
