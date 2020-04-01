using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using YD_API.ApiConnect;
using YD_API.Model;

namespace YD_API.ModelObjects.ICampaign
{
	[DataContract]
	public class CampaignResult5 : Result5<Campaign>
	{
		[DataMember(Name = "Campaigns")]
		public override Campaign[] Models { get; set; }
	}
}
