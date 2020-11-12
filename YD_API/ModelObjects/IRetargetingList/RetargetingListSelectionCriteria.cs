using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using YD_API.Model;

namespace YD_API.ModelObjects.IRetargetingList
{
	/// <summary> Критерий отбора условий ретаргетинга и подбора аудитории. Если не указан, будут получены все условия ретаргетинга и подбора аудитории, принадлежащие рекламодателю. </summary>
	[DataContract]
	public class RetargetingListSelectionCriteria
	{
		/// <summary> Отбирать условия ретаргетинга и подбора аудитории с указанными идентификаторами. От 1 до 10 000 элементов в массиве. </summary>
		[DataMember(EmitDefaultValue = false)]
		public long[] Ids { get; set; }

		/// <summary> 	Тип условия ретаргетинга и подбора аудитории. См. раздел Тип условия ретаргетинга и подбора аудитории.	 </summary>
		[DataMember(EmitDefaultValue = false)]
		RetargetingListTypeEnum[] Type { get; set; }
	}
}
