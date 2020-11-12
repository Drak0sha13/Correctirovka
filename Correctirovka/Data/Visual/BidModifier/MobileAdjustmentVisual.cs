using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;
using YD_API.Model.Enum;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class MobileAdjustmentVisual : AdjustmentVisual
	{
		/// <summary> Тип операционной системы.
		/// <remarks> Если параметр не указан, подразумевается любая операционная система. </remarks></summary>
		public MobileOperatingSystemTypeEnum? OperatingSystemType { get; set; }

		public override string Name => OperatingSystemType != null ? OperatingSystemType.ToString() : "Все";

		public MobileAdjustmentVisual()
		{
		}

		public MobileAdjustmentVisual(MobileAdjustment item) : base(item)
		{
			OperatingSystemType = item.OperatingSystemType;
		}

		public static implicit operator MobileAdjustmentVisual(MobileAdjustment item)
		{
			if (item == null)
				return null;
			return new MobileAdjustmentVisual(item);
		}
	}
}
