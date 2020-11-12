using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    /// <summary> Уровень корректировки </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BidModifierLevelEnum : byte
    {
        CAMPAIGN,
        AD_GROUP
    }
}
