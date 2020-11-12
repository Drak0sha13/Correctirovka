using System.Runtime.Serialization;
using YD_API.ApiConnect;
using YD_API.Model.BidModifierI;
using YD_API.Model.Enum;

namespace YD_API.Model
{
	[DataContract]
	public class BidModifier : BaseModel
	{
		/// <summary> Идентификатор кампании, к которой относится ключевая фраза. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long CampaignId { get; set; }

		/// <summary> Идентификатор группы объявлений, к которой относится ключевая фраза. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long? AdGroupId { get; set; }

		/// <summary> Идентификатор ключевой фразы. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long Id { get; set; }

		/// <summary> Уровень корректировки </summary>
		[DataMember(EmitDefaultValue = false)]
		public BidModifierLevelEnum Level { get; set; }

		/// <summary> Тип корректировки </summary>
		[DataMember(EmitDefaultValue = false)]
		public BidModifierTypeEnum Type { get; set; }

		/// <summary> Параметры корректировки на мобильных. </summary>
		[DataMember(EmitDefaultValue = false)]
		public MobileAdjustment MobileAdjustment { get; set; }

		/// <summary> Параметры корректировки на компьютерах, планшетах, Smart TV. </summary>
		[DataMember(EmitDefaultValue = false)]
		public Adjustment DesktopAdjustment { get; set; }

		/// <summary> Параметры корректировки ставок по полу и возрасту. </summary>
		[DataMember(EmitDefaultValue = false)]
		public DemographicsAdjustment DemographicsAdjustment { get; set; }

		/// <summary> Параметры корректировки ставок для посетивших сайт. </summary>
		[DataMember(EmitDefaultValue = false)]
		public RetargetingAdjustment RetargetingAdjustment { get; set; }

		/// <summary> Параметры корректировки ставок по региону показа. </summary>
		[DataMember(EmitDefaultValue = false)]
		public RegionalAdjustment RegionalAdjustment { get; set; }

		/// <summary> Параметры корректировки для видеодополнений. </summary>
		[DataMember(EmitDefaultValue = false)]
		public Adjustment VideoAdjustment { get; set; }

		/// <summary> Параметры корректировки ставок для смарт-баннеров. </summary>
		[DataMember(EmitDefaultValue = false)]
		public Adjustment SmartAdAdjustment { get; set; }
	}
}
