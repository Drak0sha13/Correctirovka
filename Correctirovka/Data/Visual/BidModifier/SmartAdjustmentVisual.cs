using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class SmartAdjustmentVisual : AdjustmentVisual
	{
		public override string Name => "Smart";

		public SmartAdjustmentVisual()
		{
		}

		public SmartAdjustmentVisual(Adjustment item) : base(item)
		{
		}

		public static implicit operator SmartAdjustmentVisual(Adjustment item)
		{
			if (item == null)
				return null;
			return new SmartAdjustmentVisual(item);
		}
	}
}
