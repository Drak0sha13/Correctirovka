using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ModelObjects.IBidModifier
{
	/// <summary> Перечень доступных полей для запросов </summary>       
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BidModifierFieldNamesEnum : byte
	{
		Id, CampaignId, AdGroupId, Level, Type
	};
}
