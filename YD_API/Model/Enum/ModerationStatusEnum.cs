using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModerationStatusEnum : byte
    {
        /// <summary> принята модерацией </summary>
        ACCEPTED,
        /// <summary> находится на модерации </summary>
        MODERATION,
        /// <summary> отклонена </summary>
        REJECTED
    }
}
