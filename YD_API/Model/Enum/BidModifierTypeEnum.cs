using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YD_API.Model.BidModifierI;

namespace YD_API.Model.Enum
{
	/// <summary> Тип корректировки </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BidModifierTypeEnum : byte
	{
		MOBILE_ADJUSTMENT,
		DESKTOP_ADJUSTMENT,
		DEMOGRAPHICS_ADJUSTMENT,
		RETARGETING_ADJUSTMENT,
		REGIONAL_ADJUSTMENT,
		VIDEO_ADJUSTMENT,
		SMART_AD_ADJUSTMENT,
	}
}
