using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class DesktopAdjustmentVisual : AdjustmentVisual
	{
		public override string Name => "Desktop";

		public DesktopAdjustmentVisual()
		{
		}

		public DesktopAdjustmentVisual(Adjustment item) : base(item)
		{
		}

		public static implicit operator DesktopAdjustmentVisual(Adjustment item)
		{
			if (item == null)
				return null;
			return new DesktopAdjustmentVisual(item);
		}
	}
}
