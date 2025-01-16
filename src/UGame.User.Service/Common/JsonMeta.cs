using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UGame.User.Service.Common
{
    public class JsonMeta
    {
        public JsonObject Data { get; }
        public JsonMeta(string json)
        {
            Data = !string.IsNullOrEmpty(json)
                ? JsonObject.Parse(json).AsObject() : new JsonObject();
        }
        public bool TryGet<T>(string name, out T value)
        {
            value = default;
            if (!Data.TryGetPropertyValue(name, out var node))
                return false;
            var json = node.ToJsonString();
            value = SerializerUtil.DeserializeJson<T>(json);
            return true;
        }
        public T GetOrDefault<T>(string name, T defaultValue = default)
            => TryGet<T>(name, out var value) ? value : defaultValue;
        public T GetOrException<T>(string name)
            => TryGet<T>(name, out var value)
            ? value
            : throw new Exception($"JsonMeta.GetOrException()时name不存在。name: {name} json:{Data.ToJsonString()}");

        public string ToJsonString() => Data.ToJsonString();
        public override string ToString() => Data.ToString();
    }

    public class JsonMetaJsonConverter : JsonConverter<JsonMeta>
    {
        public override JsonMeta Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (var doc = JsonDocument.ParseValue(ref reader))
            {
                var json = doc.RootElement.GetRawText();
                return new JsonMeta(json);
            }
        }

        public override void Write(Utf8JsonWriter writer, JsonMeta value, JsonSerializerOptions options)
        {
            var json = SerializerUtil.SerializeJson(value.Data, options);
            writer.WriteStringValue(json);
        }
    }
}
