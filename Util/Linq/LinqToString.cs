using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{

    public static class LinqToString
    {
        public static string CombineString<T>(this IEnumerable<T> list, string symbol = "; ")
        {
            string r = string.Empty;

            foreach (var item in list)
            {
                if (r.IsNullOrWhiteSpace() == false)
                {
                    r = "{0}{1}{2}".FormatWith(r, symbol, item.ToString());
                }
                else
                {
                    r = item.ToString();
                }
            }

            return r;

        }
    }
}
