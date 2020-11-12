
using YD_API.Model.BidModifierI;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class AdjustmentVisual
	{
		public AdjustmentVisual()
		{
		}

		protected AdjustmentVisual(Adjustment item)
		{
			BidModifier = item.BidModifier;
		}

		/// <summary> Значение коэффициента к ставке для показа объявлений  </summary>
		public int BidModifier { get; set; }

		public int Value => BidModifier - 100;

		public virtual string Name { get; }
	}
}
