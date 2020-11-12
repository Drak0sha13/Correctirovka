using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using YD_API.ApiConnect;
using YD_API.Model;

namespace YD_API.ModelObjects.IRetargetingList
{
	[DataContract]
	public class RetargetingListResult5 : Result5<RetargetingList>
	{
		[DataMember(Name = "RetargetingLists")]
		public override RetargetingList[] Models { get; set; }
	}
}
