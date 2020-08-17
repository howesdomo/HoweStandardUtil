using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util_JsonConverters
{
	public class JsonConverter_System_Drawing_Point : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(System.Drawing.Point);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var obj = JToken.Load(reader);
			if (obj.Type == JTokenType.Array)
			{
				var arr = (JArray)obj;
				if (arr.Count == 2 && arr.All(token => token.Type == JTokenType.Integer))
				{
					return new System.Drawing.Point(arr[0].Value<int>(), arr[1].Value<int>());
				}
			}
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var vector = (System.Drawing.Point)value;
			writer.WriteStartArray();
			writer.WriteValue(vector.X);
			writer.WriteValue(vector.Y);
			writer.WriteEndArray();
		}
	}
}
