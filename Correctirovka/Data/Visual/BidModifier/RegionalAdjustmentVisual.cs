using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;
using YD_API.Model.Enum;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class RegionalAdjustmentVisual : AdjustmentVisual
	{
		/// <summary> Идентификатор региона из справочника регионов. </summary>
		public long RegionId { get; set; }

		/// <summary> Идентификатор региона из справочника регионов. </summary>
		public string RegionName { get; set; }

		/// <summary> Включен или отключен набор корректировок по полу и возрасту. </summary>
		public YesNoEnum Enabled { get; set; }

		public override string Name => $"{RegionName}";

		public RegionalAdjustmentVisual()
		{
		}

		public RegionalAdjustmentVisual(RegionalAdjustment item, ClientSettings settings) : base(item)
		{
			RegionId = item.RegionId;
			try
			{
				RegionName = settings.Cash.GeoRegions.FirstOrDefault(x => x.GeoRegionId == RegionId)?.GeoRegionName;
			}
			catch (Exception ex)
			{
				RegionName = RegionId.ToString();
			}
			Enabled = item.Enabled;
		}

		public static AdjustmentVisual Create(RegionalAdjustment item, ClientSettings settings)
		{
			if (item == null)
				return null;
			return new RegionalAdjustmentVisual(item, settings);
		}
	}
}
