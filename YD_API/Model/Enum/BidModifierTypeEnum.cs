using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    /// <summary> Тип корректировки </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BidModifierTypeEnum : byte
    {
        MOBILE_ADJUSTMENT,
        DEMOGRAPHICS_ADJUSTMENT,
        RETARGETING_ADJUSTMENT,
        REGIONAL_ADJUSTMENT
    }

}
