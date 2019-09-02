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

        public static string SerializeObjectWithFormatted(object o)
        {
            System.IO.StringWriter textWriter = new System.IO.StringWriter();
            Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(textWriter)
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                Indentation = 4,
                IndentChar = ' '
            };

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Serialize(jsonWriter, o);
            return textWriter.ToString();
        }
    }
}
