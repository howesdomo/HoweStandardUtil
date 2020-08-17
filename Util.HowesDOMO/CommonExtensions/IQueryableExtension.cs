using System;
using System.Collections.Generic;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// V 1.0.0 - 2020-08-13 15:00:00
    /// 首次创建
    /// </summary>
    public static class IQueryableExtension
    {
        public static List<T> ToList<T>(this IQueryable result)
        {
            Collections.IEnumerator e = result.GetEnumerator();

            List<T> l = new List<T>();

            while (e.MoveNext())
            {
                l.Add((T)e.Current);
            }

            return l;
        }
    }
}
