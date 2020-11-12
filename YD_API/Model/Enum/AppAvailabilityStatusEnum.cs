using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppAvailabilityStatusEnum : byte
    {
        /// <summary> доступно </summary>
        AVAILABLE,
        /// <summary> недоступно </summary>
        NOT_AVAILABLE,
        /// <summary> данные из магазина приложений еще не получены </summary>
        UNPROCESSED
    }
}
