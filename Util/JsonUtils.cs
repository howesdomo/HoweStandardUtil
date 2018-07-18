using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    public class JsonUtils
    {
        public static string SerializeObject(object o)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }

        public static T DeserializeObject<T>(string jsonStr)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonStr);
        }

        public static object DeserializeObject(string jsonStr, Type type)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStr, type);
        }
    }
}
