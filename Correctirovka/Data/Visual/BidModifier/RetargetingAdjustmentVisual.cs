using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model.BidModifierI;
using YD_API.Model.Enum;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class RetargetingAdjustmentVisual : AdjustmentVisual
	{
		/// <summary> Идентификатор условия подбора аудитории. </summary>
		public long RetargetingConditionId { get; set; }

		public string RetargetingName { get; set; }

		/// <summary> Признак того, что все цели и сегменты в условии подбора аудитории доступны рекламодателю. Значение NO — одна или несколько целей или один или несколько сегментов недоступны. </summary>
		public YesNoEnum Accessible { get; set; }

		/// <summary> Включен или отключен набор корректировок по полу и возрасту. </summary>
		public YesNoEnum Enabled { get; set; }

		public override string Name => $"{RetargetingName}";

		public RetargetingAdjustmentVisual()
		{
		}

		public RetargetingAdjustmentVisual(RetargetingAdjustment item, ClientSettings settings) : base(item)
		{
			RetargetingConditionId = item.RetargetingConditionId;
			Accessible = item.Accessible;
			Enabled = item.Enabled;

			RetargetingName = settings?.RetargetingListCash
								.Where(x => x.ID == RetargetingConditionId)
								.Select(x => x.Name)
								.FirstOrDefault();
		}

		public static implicit operator RetargetingAdjustmentVisual(RetargetingAdjustment item)
		{
			if (item == null)
				return null;
			return new RetargetingAdjustmentVisual(item, null);
		}

		public static AdjustmentVisual Create(RetargetingAdjustment item, ClientSettings settings)
		{
			if (item == null)
				return null;
			return new RetargetingAdjustmentVisual(item, settings);
		}
	}
}
