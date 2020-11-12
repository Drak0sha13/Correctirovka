using System.Runtime.Serialization;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.IRetargetingList
{
	public class RetargetingListParamsRequest : PageParamsRequest<RetargetingListFieldEnum>
	{
		/// <summary> Критерий отбора условий ретаргетинга и подбора аудитории. Если не указан, будут получены все условия ретаргетинга и подбора аудитории, принадлежащие рекламодателю. </summary>
		[DataMember]
		public RetargetingListSelectionCriteria SelectionCriteria { get; set; } = new RetargetingListSelectionCriteria();

	}
}
