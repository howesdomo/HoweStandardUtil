using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    /// <summary>
    /// V 1.0.1 - 2020-1-23 14:38:59
    /// 1) SerializeObjectWithFormatted 增加缩放符号参数
    /// 2) 增加两个解决对于 EF Model 序列化时出现 Error Self referencing loop detected for type 错误
    /// </summary>
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

        public static string SerializeObjectWithFormatted(object o, char indentChar = ' ', int indentation = 4)
        {
            System.IO.StringWriter textWriter = new System.IO.StringWriter();
            Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(textWriter)
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                Indentation = indentation,
                IndentChar = indentChar
            };

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Serialize(jsonWriter, o);
            return textWriter.ToString();
        }

        /// <summary>
        /// 解决在序列化 EF Model 时遇到的 JSON.NET Error Self referencing loop detected for type 错误
        /// 解决方法一 ( 较优 )
        /// </summary>
        /// <param name="o"></param>
        /// <param name="isFormat"></param>
        /// <param name="indentChar"></param>
        /// <param name="indentation"></param>
        /// <returns></returns>
        public static string SerializeObject_IgnoreReferenceLoopHandling(object o, bool isFormat = false, char indentChar = ' ', int indentation = 4)
        {
            System.IO.StringWriter textWriter = new System.IO.StringWriter();
            Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(textWriter);

            if (isFormat)
            {
                jsonWriter.Formatting = Newtonsoft.Json.Formatting.Indented;
                jsonWriter.IndentChar = indentChar;
                jsonWriter.Indentation = indentation;
            }

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; // 核心 - 忽略 EF Model, JSON.NET Error Self referencing loop detected for type

            serializer.Serialize(jsonWriter, o);
            return textWriter.ToString();
        }

        /// <summary>
        /// 解决在序列化 EF Model 时遇到的 JSON.NET Error Self referencing loop detected for type 错误
        /// 解决方法一 ( 较优 )
        /// </summary>
        /// <param name="o"></param>
        /// <param name="isFormat"></param>
        /// <param name="indentChar"></param>
        /// <param name="indentation"></param>
        /// <returns></returns>
        public static string SerializeObject_SerializeReferenceLoopHandling(object o, bool isFormat = false, char indentChar = ' ', int indentation = 4)
        {
            System.IO.StringWriter textWriter = new System.IO.StringWriter();
            Newtonsoft.Json.JsonTextWriter jsonWriter = new Newtonsoft.Json.JsonTextWriter(textWriter);

            if (isFormat)
            {
                jsonWriter.Formatting = Newtonsoft.Json.Formatting.Indented;
                jsonWriter.IndentChar = indentChar;
                jsonWriter.Indentation = indentation;
            }

            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();

            // 核心 - 忽略 EF Model, JSON.NET Error Self referencing loop detected for type
            serializer.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize; 
            serializer.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            // End 核心

            serializer.Serialize(jsonWriter, o);
            return textWriter.ToString();
        }
    }
}
