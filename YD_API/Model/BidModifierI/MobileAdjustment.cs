using System.Runtime.Serialization;
using YD_API.Model.Enum;

namespace YD_API.Model.BidModifierI
{
	[DataContract]
	public class MobileAdjustment
	{
		/// <summary>  Значение коэффициента к ставке </summary>
		[DataMember(EmitDefaultValue = false)]
		public int BidModifier { get; set; }

		/// <summary> Тип операционной системы.
		/// <remarks> Если параметр не указан, подразумевается любая операционная система. </remarks></summary>
		[DataMember(EmitDefaultValue = false)]
		public MobileOperatingSystemTypeEnum? OperatingSystemType { get; set; }
	}
}
