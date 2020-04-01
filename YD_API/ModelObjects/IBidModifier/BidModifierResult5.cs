using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using YD_API.ApiConnect;
using YD_API.Model;

namespace YD_API.ModelObjects.IBidModifier
{
	[DataContract]
	public class BidModifierResult5 : Result5<BidModifier>
	{
		[DataMember(Name = "BidModifiers")]
		public override BidModifier[] Models { get; set; }
	}
}
