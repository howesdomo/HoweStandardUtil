using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Util
{
    public class CommonDal
    {
        public static decimal ReadDecimal(object value)
        {
            decimal result = 0;
            if (value != DBNull.Value)
            {
                result = Convert.ToDecimal(value);
            }
            return result;
        }

        public static decimal? ReadDecimalNullable(object value)
        {
            decimal? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToDecimal(value);
            }
            return result;
        }

        public static double ReadDouble(object value)
        {
            double result = 0;
            if (value != DBNull.Value)
            {
                result = Convert.ToDouble(value);
            }
            return result;
        }

        public static double? ReadDoubleNullable(object value)
        {
            double? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToDouble(value);
            }
            return result;
        }

        public static int ReadInt(object value)
        {
            int result = 0;
            if (value != DBNull.Value)
            {
                result = Convert.ToInt32(value);
            }
            return result;
        }

        public static int? ReadIntNullable(object value)
        {
            int? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToInt32(value);
            }
            return result;
        }

        public static long ReadLong(object value)
        {
            long result = 0;
            if (value != DBNull.Value)
            {
                result = Convert.ToInt64(value);
            }
            return result;
        }

        public static long? ReadLongNullable(object value)
        {
            long? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToInt64(value);
            }
            return result;
        }

        public static DateTime ReadDateTime(object value)
        {
            DateTime result = DateTime.MinValue;
            if (value != DBNull.Value)
            {
                result = Convert.ToDateTime(value);
            }
            return result;
        }

        public static DateTime? ReadDateTimeNullable(object value)
        {
            DateTime? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToDateTime(value);
            }
            return result;
        }

        public static bool ReadBoolean(object value)
        {
            bool result = false;
            if (value != DBNull.Value)
            {
                result = Convert.ToBoolean(value);
            }
            return result;
        }

        public static bool? ReadBooleanNullable(object value)
        {
            bool? result = null;
            if (value != DBNull.Value)
            {
                result = Convert.ToBoolean(value);
            }
            return result;
        }

        public static Guid ReadGuid(object value)
        {
            Guid result = Guid.Empty;
            if (value != DBNull.Value)
            {
                result = Guid.Parse(value.ToString());
            }
            return result;
        }

        public static Guid? ReadGuidNullable(object value)
        {
            Guid? result = null;
            if (value != DBNull.Value)
            {
                result = Guid.Parse(value.ToString());
            }
            return result;
        }

        public static string ReadString(object value)
        {
            string result = string.Empty;
            if (value != null && value != DBNull.Value)
            {
                result = value.ToString();
            }
            return result;
        }

        public static object CheckIsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }

        public static string GetCodeName(string code, string name)
        {
            if (code.Equals(name))
            {
                return code;
            }
            string codeName = string.Empty;
            if (!string.IsNullOrEmpty(code))
            {
                if (!string.IsNullOrEmpty(name))
                {
                    codeName = string.Format("{0}-{1}", code, name);
                }
                if (string.IsNullOrEmpty(codeName))
                {
                    codeName = code;
                }
            }

            if (string.IsNullOrEmpty(codeName))
            {
                codeName = name;
            }
            return codeName;
        }

        /// <summary>
        /// 读取 Mssql 的 Time类型，返回DateTime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ReadTimeSpanToDateTime(object value)
        {
            DateTime result = DateTime.MinValue;
            if (value != DBNull.Value)
            {
                result = new DateTime(((TimeSpan)value).Ticks);
            }
            return result;
        }

        public static SqlParameter GetSqlParameter(string name, bool? value)
        {
            if (value.HasValue == false)
            {
                return new SqlParameter(name, DBNull.Value);
            }
            else
            {
                return new SqlParameter(name, value.Value);
            }
        }

        public static SqlParameter GetSqlParameter(string name, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new SqlParameter(name, DBNull.Value);
            }
            else
            {
                return new SqlParameter(name, value);
            }
        }

        public static SqlParameter GetSqlParameter(string name, DateTime? value)
        {
            if (value.HasValue == false)
            {
                return new SqlParameter(name, DBNull.Value);
            }
            else
            {
                return new SqlParameter(name, value.Value);
            }
        }

        public static SqlParameter GetSqlParameter(string name, int? value)
        {
            if (value.HasValue == false)
            {
                return new SqlParameter(name, DBNull.Value);
            }
            else
            {
                return new SqlParameter(name, value.Value);
            }
        }

        public static List<string> GetDataTableColumnNames(DataTable dt)
        {
            List<string> r = new List<string>();
            foreach (DataColumn item in dt.Columns)
            {
                r.Add(item.ColumnName);
            }
            return r;
        }
    }
}