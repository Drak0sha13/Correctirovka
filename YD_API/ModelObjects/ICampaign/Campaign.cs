using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API_Yandex_Direct.Model.Enum;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.ICampaign
{
	public class CampaignObject : ModelObject, IGetU5<CampaignParamsRequest, CampaignResult5>
	{
		protected readonly ApiConnect5 apiConnect;

		public CampaignObject(ApiConnect5 api)
		{
			apiConnect = api;
		}

		public override string Name => "campaigns";

		public Task<GetResult5<CampaignResult5>> GetAsync(string userName)
		{
			return GetAsync(userName, new CampaignParamsRequest()
			{
				FieldNames = new[] {
					CampaignFieldNamesEnum.Id,
					CampaignFieldNamesEnum.Name,
					CampaignFieldNamesEnum.Status,
					CampaignFieldNamesEnum.State,
				},
				SelectionCriteria = new CampaignsSelectionCriteria()
				{
					States = new []
					{
						CampaignStateEnum.CONVERTED,
						CampaignStateEnum.ENDED,
						CampaignStateEnum.OFF,
						CampaignStateEnum.ON,
						CampaignStateEnum.SUSPENDED,
					}
				}
			});
		}

		public Task<GetResult5<CampaignResult5>> GetAsync(string userName, CampaignParamsRequest request)
		{
			var req = new RequestObjectV5<CampaignParamsRequest>()
			{
				Method = MethodEnum.Get,
				Params = request,
			};
			return apiConnect.GetAsync<GetResult5<CampaignResult5>>(req, this, new UserHeader(userName));
		}
	}
}
