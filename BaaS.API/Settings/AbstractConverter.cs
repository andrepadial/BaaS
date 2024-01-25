using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaaS.API.Settings
{
    public class AbstractConverter<TAbstract, TReal> : JsonConverter
        where TReal : TAbstract
    {
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(TAbstract);

        public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer jser) =>
            jser.Deserialize<TReal>(reader);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer jser) =>
            jser.Serialize(writer, value);
    }
}
