using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceTypeGetEnum : byte
    { RETAIL_FEED }
}
