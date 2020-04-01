using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YD_API.ApiConnect;
using YD_API.Model.Enum;

namespace YD_API.ModelObjects.IBidModifier
{
	public class BidModifierParamsRequest : ParamsRequest<BidModifierFieldNamesEnum>
	{
		/// <summary> Критерий отбора групп. </summary>
		[DataMember]
		public BidModifiersSelectionCriteria SelectionCriteria { get; set; } = new BidModifiersSelectionCriteria();

		/// <summary> Имена параметров корректировок на мобильных, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public MobileAdjustmentFieldNamesList[] MobileAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок на компьютерах, планшетах, Smart TV, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public AdjustmentFieldNamesList[] DesktopAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок по полу и возрасту, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public DemographicsAdjustmentFieldNamesList[] DemographicsAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок для целевой аудитории, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public RetargetingAdjustmentFieldNamesList[] RetargetingAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок по региону показа, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public RegionalAdjustmentFieldNamesList[] RegionalAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок для видеодополнений, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public AdjustmentFieldNamesList[] VideoAdjustmentFieldNames { get; set; }

		/// <summary> Имена параметров корректировок для смарт-объявлений, которые требуется получить </summary>
		[DataMember(EmitDefaultValue = false)]
		public AdjustmentFieldNamesList[] SmartAdAdjustmentFieldNames { get; set; }
	}

	/// <summary> Имена параметров корректировок на мобильных, которые требуется получить </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MobileAdjustmentFieldNamesList { BidModifier , OperatingSystemType }

	/// <summary>  </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AdjustmentFieldNamesList { BidModifier }

	/// <summary> Имена параметров корректировок по полу и возрасту, которые требуется получить </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DemographicsAdjustmentFieldNamesList { Gender , Age , BidModifier , Enabled }

	/// <summary> Имена параметров корректировок для целевой аудитории, которые требуется получить </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RetargetingAdjustmentFieldNamesList { RetargetingConditionId , BidModifier , Accessible , Enabled }

	/// <summary> Имена параметров корректировок по региону показа, которые требуется получить </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RegionalAdjustmentFieldNamesList { RegionId , BidModifier , Enabled }
}
