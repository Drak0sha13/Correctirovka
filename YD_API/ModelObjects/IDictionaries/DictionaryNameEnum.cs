using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ModelObjects.IDictionaries
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DictionaryNameEnum
	{
		Currencies,
		MetroStations,
		GeoRegions,
		TimeZones,
		Constants,
		AdCategories,
		OperationSystemVersions,
		ProductivityAssertions,
		SupplySidePlatforms,
		Interests,
		AudienceCriteriaTypes,
		AudienceDemographicProfiles,
		AudienceInterests,
	}
}
