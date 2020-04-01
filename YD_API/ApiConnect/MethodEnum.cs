using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ApiConnect
{
	[JsonConverter(typeof(StringEnumConverter), true)]
	public enum MethodEnum :byte
	{
		[DataMember(Name = "get")]    
		Get,
	}
}
