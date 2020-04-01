using System.Runtime.Serialization;
using YD_API.ApiConnect;
using YD_API.Model;

namespace YD_API.ModelObjects.IClient
{
	[DataContract]
	public class ClientResult5 : Result5<Client>
	{
		[DataMember(Name = "Clients")]
		public override Client[] Models { get; set; }
	}
}
