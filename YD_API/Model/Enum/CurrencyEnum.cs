using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    /// <summary>
    /// Справочник валют
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyEnum : byte { RUB, BYN, CHF, EUR, KZT, TRY, UAH, USD, YND_FIXED }
}
