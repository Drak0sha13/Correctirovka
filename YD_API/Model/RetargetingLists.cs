using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YD_API.ApiConnect;
using YD_API.Model.Enum;

namespace YD_API.Model
{
	[DataContract]
	public class RetargetingList : BaseModel
	{
		/// <summary> 	Тип условия ретаргетинга и подбора аудитории. См. раздел Тип условия ретаргетинга и подбора аудитории.	 </summary>
		[DataMember]
		public RetargetingListTypeEnum? Type { get; set; }

		/// <summary> 	Идентификатор условия ретаргетинга и подбора аудитории.	 </summary>
		[DataMember(EmitDefaultValue = false)]
		public long Id { get; set; }

		/// <summary> 	Название условия ретаргетинга и подбора аудитории (не более 250 символов).	 </summary>
		[DataMember(EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary> 	Текстовое примечание к условию ретаргетинга и подбора аудитории (не более 4096 символов).	 </summary>
		[DataMember(EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary> 	YES — все цели и сегменты в условии ретаргетинга и подбора аудитории доступны; NO — в условии есть недоступная цель или сегмент, показ объявлений и корректировки ставок по данному условию не осуществляются.
		/// Цель или сегмент становятся недоступными в случае удаления или в случае, если доступ отменен владельцем (см. раздел Управление доступом к счетчику помощи Яндекс.Метрики).</summary>
		[DataMember(EmitDefaultValue = false)]
		public YesNoEnum? IsAvailable { get; set; }

		/// <summary> 	Правила отбора посетителей сайта. Посетитель удовлетворяет условию ретаргетинга и подбора аудитории, если для него выполнены одновременно все правила.
		/// Ограничения на правила отбора и примеры структуры приведены в разделе Правила отбора пользователей.</summary>
		[DataMember(EmitDefaultValue = false)]
		public RetargetingListRuleItem[] Rules { get; set; }

		/// <summary> 	Область применения условия ретаргетинга и подбора аудитории: в условиях нацеливания на аудиторию, в корректировках ставок или везде. См. раздел Область применения.	 </summary>
		[DataMember(EmitDefaultValue = false)]
		public RetargetingListScopeEnum? Scope { get; set; }

		/// <summary> 	Область применения условия ретаргетинга и подбора аудитории: типы групп, в которые можно добавить условие нацеливания на аудиторию по данному условию ретаргетинга.
		/// null (nil) — условие ретаргетинга может применяться только в корректировках ставок.</summary>
		[DataMember(EmitDefaultValue = false)]
		public AvailableForTargetsInAdGroupTypesArray AvailableForTargetsInAdGroupTypes { get; set; }
	}

	/// <summary> 		 </summary>
	[DataContract]
	public class RetargetingListRuleItem
	{
		/// <summary> 	Цели и сегменты.	 </summary>
		[DataMember(EmitDefaultValue = false)]
		public RetargetingListRuleArgumentItem[] Arguments { get; set; }

		/// <summary> 	Логический оператор правила отбора:	 </summary>
		[DataMember]
		public RetargetingListRuleOperatorEnum Operator { get; set; }
	}

	/// <summary> 		 </summary>
	[DataContract]
	public class RetargetingListRuleArgumentItem
	{
		/// <summary> 	Количество дней (от 1 до 540), за которое проверяется выполнение цели.
		/// Для сегментов Яндекс.Метрики и сегментов Яндекс.Аудиторий параметр не используется.</summary>
		[DataMember]
		public int MembershipLifeSpan { get; set; }

		/// <summary> 	Идентификатор цели или сегмента.	 </summary>
		[DataMember]
		public long ExternalId { get; set; }
	}

	/// <summary> 		 </summary>
	[DataContract]
	public class AvailableForTargetsInAdGroupTypesArray
	{
		/// <summary> 	Типы групп, в которые можно добавлять условие нацеливания на аудиторию по данному условию ретаргетинга и подбора аудитории.	 </summary>
		public AdGroupTypesEnum[] Items { get; set; }
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum RetargetingListTypeEnum
	{
		RETARGETING, AUDIENCE
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum RetargetingListScopeEnum
	{
		FOR_TARGETS_AND_ADJUSTMENTS,
		FOR_ADJUSTMENTS_ONLY,
		FOR_TARGETS_ONLY
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum RetargetingListRuleOperatorEnum
	{
		/// <summary> правило выполнено, если пользователь выполнил все цели и входит во все сегменты;	 </summary>
		ALL,
		/// <summary> правило выполнено, если пользователь выполнил хотя бы одну из целей или входит хотя бы в один из сегментов;	 </summary>
		ANY,
		/// <summary> правило выполнено, если пользователь не выполнил ни одну из целей и не входит ни в один из сегментов.	 </summary>
		NONE
	}
}
