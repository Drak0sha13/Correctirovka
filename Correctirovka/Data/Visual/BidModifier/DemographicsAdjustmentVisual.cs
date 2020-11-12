using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.BidModifierI;
using YD_API.Model.Enum;

namespace Correctirovka.Data.Visual.BidModifier
{
	public class DemographicsAdjustmentVisual : AdjustmentVisual
	{
		/// <summary> Пол пользователя </summary>
		public GenderEnum? Gender { get; set; }

		/// <summary> Возрастная группа пользователя </summary>
		public AgeRangeEnum? Age { get; set; }

		/// <summary> Включен или отключен набор корректировок по полу и возрасту. </summary>
		public YesNoEnum Enabled { get; set; }

		public override string Name => $"{Gender} {Age}";

		public DemographicsAdjustmentVisual()
		{
		}

		public DemographicsAdjustmentVisual(DemographicsAdjustment item) : base(item)
		{
			Gender = item.Gender;
			Age = item.Age;
			Enabled = item.Enabled;
		}

		public static implicit operator DemographicsAdjustmentVisual(DemographicsAdjustment item)
		{
			if (item == null)
				return null;
			return new DemographicsAdjustmentVisual(item);
		}
	}
}
