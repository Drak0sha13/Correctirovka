using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PriorityEnum : byte { LOW, NORMAL, HIGH }
}
