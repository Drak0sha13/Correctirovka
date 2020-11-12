using System.Threading.Tasks;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.IRetargetingList
{
	public class RetargetingListObject : ModelObject, IGetU5<RetargetingListParamsRequest, RetargetingListResult5>
	{
		protected readonly ApiConnect5 apiConnect;

		public RetargetingListObject(ApiConnect5 api)
		{
			apiConnect = api;
		}

		public override string Name => "retargetinglists";	

		public Task<GetResult5<RetargetingListResult5>> GetNameByIdAsync(string userName, params long[] id)
		{
			return GetAsync(userName,
				new RetargetingListParamsRequest()
				{
					FieldNames = new[]
					{
						RetargetingListFieldEnum.Id
						, RetargetingListFieldEnum.Name
					},
					SelectionCriteria = new RetargetingListSelectionCriteria()
					{
						Ids = id
					}
				});
		}

		public Task<GetResult5<RetargetingListResult5>> GetAsync(string userName, RetargetingListParamsRequest request)
		{
			var req = new RequestObjectV5<RetargetingListParamsRequest>()
			{
				Method = MethodEnum.Get,
				Params = request,
			};
			return apiConnect.GetAsync<GetResult5<RetargetingListResult5>>(req, this, new UserHeader(userName));
		}
	}
}
