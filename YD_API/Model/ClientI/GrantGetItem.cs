﻿using System.Runtime.Serialization;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.Enum;

namespace YD_API.Model.ClientI
{
    /// <summary> Полномочия рекламодателя по управлению кампаниями. </summary>
    [DataContract]
    public class GrantGetItem
    {
        /// <summary> Имя полномочия </summary>
        [DataMember(EmitDefaultValue = false)]
        public PrivilegeEnum Privilege { get; set; }

        /// <summary> Есть ли у клиента данное полномочие. </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Value { get; set; }

        /// <summary> Название рекламного агентства, если полномочие предоставлено агентством. </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Agency { get; set; }
    }

}
