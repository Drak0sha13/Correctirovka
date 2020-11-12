using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YD_API.ApiConnect;
using YD_API.Model.Enum;
using YD_API.ModelObjects.IClient;

namespace YD_API.ModelObjects.IBidModifier
{
	public class BidModifierObject : ModelObject, IGetU5<BidModifierParamsRequest, BidModifierResult5>
	{
		protected readonly ApiConnect5 apiConnect;

		public BidModifierObject(ApiConnect5 api)
		{
			apiConnect = api;
		}

		public override string Name => "bidmodifiers";

		public Task<GetResult5<BidModifierResult5>> GetAsync(string userName, params long[] campaignIds)
		{
			return GetAsync(userName, new BidModifierParamsRequest()
			{
				FieldNames = new[]
				{
					BidModifierFieldNamesEnum.AdGroupId,
					BidModifierFieldNamesEnum.CampaignId,
					BidModifierFieldNamesEnum.Id,
					BidModifierFieldNamesEnum.Level,
					BidModifierFieldNamesEnum.Type,
				},
				SelectionCriteria = new BidModifiersSelectionCriteria()
				{
					CampaignIds = campaignIds,
					Levels = new []{BidModifierLevelEnum.AD_GROUP, BidModifierLevelEnum.CAMPAIGN}
				},
				MobileAdjustmentFieldNames = new []{MobileAdjustmentFieldNamesList.BidModifier,MobileAdjustmentFieldNamesList.OperatingSystemType},
				DesktopAdjustmentFieldNames = new []{AdjustmentFieldNamesList.BidModifier},
				DemographicsAdjustmentFieldNames =  new[]
				{
					DemographicsAdjustmentFieldNamesList.Age,
					DemographicsAdjustmentFieldNamesList.BidModifier,
					DemographicsAdjustmentFieldNamesList.Enabled,
					DemographicsAdjustmentFieldNamesList.Gender
				},
				RetargetingAdjustmentFieldNames = new []
				{
					RetargetingAdjustmentFieldNamesList.Accessible,
					RetargetingAdjustmentFieldNamesList.BidModifier,
					RetargetingAdjustmentFieldNamesList.Enabled,
					RetargetingAdjustmentFieldNamesList.RetargetingConditionId
				},
				RegionalAdjustmentFieldNames = new []
				{
					RegionalAdjustmentFieldNamesList.BidModifier,
					RegionalAdjustmentFieldNamesList.Enabled,
					RegionalAdjustmentFieldNamesList.RegionId
				},
				SmartAdAdjustmentFieldNames = new []{AdjustmentFieldNamesList.BidModifier},
				VideoAdjustmentFieldNames = new []{AdjustmentFieldNamesList.BidModifier}
			});
		}

		public Task<GetResult5<BidModifierResult5>> GetAsync(string userName, BidModifierParamsRequest request)
		{
			var req = new RequestObjectV5<BidModifierParamsRequest>()
			{
				Method = MethodEnum.Get,
				Params = request,
			};
			return apiConnect.GetAsync<GetResult5<BidModifierResult5>>(req, this, new UserHeader(userName));

		}
	}
}
