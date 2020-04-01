using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.Enum;

namespace YD_API.ModelObjects.IBidModifier
{
	/// <summary> Критерий отбора фраз. </summary>
	[DataContract]
	public class BidModifiersSelectionCriteria
	{
		/// <summary> Отбирать фразы с указанными идентификаторами. От 1 до 10 000 элементов в массиве. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long[] Ids { get; set; }

		/// <summary> Отбирать фразы указанных групп. От 1 до 1000 элементов в массиве. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long[] AdGroupIds { get; set; }

		/// <summary> Отбирать фразы указанных кампаний. От 1 до 10 элементов в массиве. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long[] CampaignIds { get; set; }

		/// <summary> Отбирать фразы с указанными состояниями.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public BidModifierTypeEnum[] Types { get; set; }

		/// <summary> Отбирать фразы с указанными состояниями.  </summary>
		[DataMember]
		public BidModifierLevelEnum[] Levels { get; set; }
	}
}
