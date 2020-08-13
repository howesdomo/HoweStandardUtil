using System;
using System.Collections.Generic;
using System.Text;

namespace System.Collections
{
    /// <summary>
    /// V 1.0.1 - 2020-08-13 14:31:25
    /// 增加 ToList T 方法
    /// 
    /// V 1.0.0 - 2020-07-21 15:41:22
    /// 首次创建
    /// </summary>
    public static class IListExtension
    {
        public static IList Except(this IList bigger, IList smaller)
        {
            return IListExtension.Except_ActualMethod(bigger, smaller);
        }

        static IList Except_ActualMethod(IList bigger, IList smaller)
        {
            List<object> l = new List<object>();

            if (smaller == null)
            {
                return bigger;
            }

            for (int indexOfBigger = 0; indexOfBigger < bigger.Count; indexOfBigger++)
            {
                bool isMatch = false;

                int bHashCode = bigger[indexOfBigger].GetHashCode();
                for (int indexOfSmaller = 0; indexOfSmaller < smaller.Count; indexOfSmaller++)
                {
                    int sHashCode = smaller[indexOfSmaller].GetHashCode();
                    if (bHashCode == sHashCode)
                    {
                        isMatch = true;
                        break;
                    }
                }

                if (isMatch == false)
                {
                    l.Add(bigger[indexOfBigger]);
                }
            }

            if (l.Count <= 0)
            {
                return null;
            }

            IList r = (IList)l;
            return r;
        }

        public static List<T> ToList<T>(this IList l)
        {
            List<T> r = new List<T>();

            foreach (object item in l)
            {
                r.Add((T)item);
            }

            return r;
        }
    }
}
