using System.Linq;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.Enum;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class BidModifierVisual
	{
		/// <summary> Идентификатор кампании, к которой относится ключевая фраза. </summary>
		public long CampaignId { get; set; }

		/// <summary> Название кампании, к которой относится ключевая фраза. </summary>
		public string CampaignName { get; set; }

		//<DisplayTemplate>
		//@{
		//	var product = context as BidModifier;
		//	if (product != null)
		//	{
		//		<span>@Settings.CampaignCash.Where(x => x.ID == product.CampaignId).Select(x => x.Name).FirstOrDefault()</span>
		//	}
		//}
		//</DisplayTemplate>

		/// <summary> Идентификатор группы объявлений, к которой относится ключевая фраза. </summary>
		public long? AdGroupId { get; set; }

		/// <summary> Идентификатор ключевой фразы. </summary>
		public long Id { get; set; }

		/// <summary> Уровень корректировки </summary>
		public BidModifierLevelEnum Level { get; set; }

		/// <summary> Тип корректировки </summary>
		public BidModifierTypeEnum Type { get; set; }

		/// <summary> Параметры корректировки </summary>
		public AdjustmentVisual Adjustment { get; set; }

		public BidModifierVisual()
		{
		}

		public BidModifierVisual(YD_API.Model.BidModifier item, ClientSettings settings)
		{
			CampaignId = item.CampaignId;
			AdGroupId = item.AdGroupId;
			Id = item.Id;
			Level = item.Level;
			Type = item.Type;
			Adjustment = (MobileAdjustmentVisual) item.MobileAdjustment
			             ?? (DesktopAdjustmentVisual) item.DesktopAdjustment
			             ?? (DemographicsAdjustmentVisual) item.DemographicsAdjustment
			             ?? RetargetingAdjustmentVisual.Create(item.RetargetingAdjustment, settings)
			             ?? RegionalAdjustmentVisual.Create(item.RegionalAdjustment, settings)
			             ?? (VideoAdjustmentVisual) item.VideoAdjustment
			             ?? (AdjustmentVisual) (SmartAdjustmentVisual) item.SmartAdAdjustment;

			CampaignName = settings?.CampaignCash.Where(x => x.ID == CampaignId).Select(x => x.Name).FirstOrDefault();
		}

		public static implicit operator BidModifierVisual(YD_API.Model.BidModifier item)
		{
			var rez = new BidModifierVisual(item, null);
			return rez;
		}
	}
}
