using System.Runtime.Serialization;
using Newtonsoft.Json;
using YD_API.Model.Enum;

namespace YD_API.Model.BidModifierI
{
	[DataContract]
	public class MobileAdjustment : Adjustment
	{
		/// <summary> Тип операционной системы.
		/// <remarks> Если параметр не указан, подразумевается любая операционная система. </remarks></summary>
		[DataMember(EmitDefaultValue = false)]
		public MobileOperatingSystemTypeEnum? OperatingSystemType { get; set; }
	}
}
