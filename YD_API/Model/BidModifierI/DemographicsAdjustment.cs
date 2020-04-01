﻿using System.Runtime.Serialization;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.Enum;

namespace YD_API.Model.BidModifierI
{
    [DataContract]
    public class DemographicsAdjustment
    {
        /// <summary> Пол пользователя </summary>
        [DataMember(EmitDefaultValue = false)]
        public GenderEnum Gender { get; set; }
        
        /// <summary> Возрастная группа пользователя </summary>
        [DataMember(EmitDefaultValue = false)]
        public AgeRangeEnum Age { get; set; }

        /// <summary> Включен или отключен набор корректировок по полу и возрасту. </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Enabled { get; set; }

        /// <summary> Значение коэффициента к ставке </summary>
        [DataMember(EmitDefaultValue = false)]
        public int BidModifier { get; set; }
    }

}
