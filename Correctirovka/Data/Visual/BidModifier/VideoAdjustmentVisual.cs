using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class VideoAdjustmentVisual : AdjustmentVisual
	{
		public override string Name => "Video";

		public VideoAdjustmentVisual()
		{
		}

		public VideoAdjustmentVisual(Adjustment item) : base(item)
		{
		}

		public static implicit operator VideoAdjustmentVisual(Adjustment item)
		{
			if (item == null)
				return null;
			return new VideoAdjustmentVisual(item);
		}
	}
}
