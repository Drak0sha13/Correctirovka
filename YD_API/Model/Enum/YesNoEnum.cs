using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum YesNoEnum : byte { YES, NO }
}
