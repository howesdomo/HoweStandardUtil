using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Data
{
    public static class DataSetExtension
    {
        public static List<T> GetList<T>(this DataSet ds, int tableIndex = 0)
        {
            DataTable dt = ds.Tables[tableIndex];
            return dt.GetList<T>();            
        }

        public static System.Collections.Generic.List<dynamic> GetList(this DataSet ds, int tableIndex = 0)
        {
            DataTable dt = ds.Tables[tableIndex];
            return dt.GetList();
        }
    }
}
