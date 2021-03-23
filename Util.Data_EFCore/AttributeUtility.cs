using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util.Data_EFCore
{
    /// <summary>
    /// 属性工具类
    /// 
    /// V 1.0.0 - 2021-03-16 11:29:19
    /// 首次从 SecuritySolution 整理到 Util.Data_EFCore 中
    /// </summary>
    public class AttributeUtility
    {
        public static Dictionary<string, object> GetClassAttributes<T>(bool isGetCustomAttribute = false)
        {
            return typeof(T)
                   .GetCustomAttributes(isGetCustomAttribute)
                   .ToDictionary(a => a.GetType().Name, a => a);
        }

        public static Dictionary<string, List<object>> GetPropertyAttributes<T>(string propertyName, bool isGetCustomAttribute = false)
        {
            var dict = new Dictionary<string, List<object>>();
            object[] attrs = typeof(T).GetProperty(propertyName).GetCustomAttributes(isGetCustomAttribute);
            for (var i = 0; i < attrs.Length; i++)
            {
                string key = attrs[i].GetType().Name;
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(attrs[i]);
                }
                else
                {
                    dict.Add(key, new List<object>() { attrs[i] });
                }
            }
            return dict;
        }
    }
}
