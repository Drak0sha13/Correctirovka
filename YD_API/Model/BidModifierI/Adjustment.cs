using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace YD_API.Model.BidModifierI
{
	[DataContract]
	public class Adjustment
	{
		/// <summary> Значение коэффициента к ставке для показа объявлений  </summary>
		[DataMember(EmitDefaultValue = false)]
		public int BidModifier { get; set; }
	}
}
