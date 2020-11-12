using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ModelObjects.IRetargetingList
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RetargetingListFieldEnum
	{
		Type,
		Id,
		Name,
		Description,
		Rules,
		IsAvailable,
		Scope,
		AvailableForTargetsInAdGroupTypes
	}
}
