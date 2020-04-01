using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ModelObjects.ICampaign
{
	/// <summary> Перечень доступных полей для запросов </summary>       
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CampaignFieldNamesEnum : byte
	{
		BlockedIps, ExcludedSites, Currency, DailyBudget, Notification, EndDate, Funds, ClientInfo, Id, Name,
		NegativeKeywords, RepresentedBy, StartDate, Statistics, State, Status, StatusPayment,
		StatusClarification, SourceId, TimeTargeting, TimeZone, Type
	};
}
