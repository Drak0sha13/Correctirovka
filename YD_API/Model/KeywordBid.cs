﻿using System.Runtime.Serialization;
using YD_API.Model.Enum;
using YD_API.Model.KeywordBidl;

namespace YD_API.Model
{
    [DataContract]
    public class KeywordBid
    {
        /// <summary> Идентификатор кампании, к которой относится ключевая фраза. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long CampaignId { get; set; }

        /// <summary> Идентификатор группы объявлений, к которой относится ключевая фраза. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long AdGroupId { get; set; }

        /// <summary> Идентификатор ключевой фразы. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long KeywordId { get; set; }

        /// <summary> Статус возможности показов группы объявлений. </summary>
        [DataMember(EmitDefaultValue = false)]
        public ServingStatusEnum ServingStatus { get; set; }

        /// <summary> Приоритет фразы. </summary>
        [DataMember(EmitDefaultValue = false)]
        public PriorityEnum? StrategyPriority { get; set; }

        /// <summary> Ставка и данные торгов на поиске. </summary>
        [DataMember(EmitDefaultValue = false)]
        public Search Search { get; set; }

        /// <summary> Ставка и данные торгов в сетях. </summary>
        [DataMember(EmitDefaultValue = false)]
        public Network Network { get; set; }
    }
}
