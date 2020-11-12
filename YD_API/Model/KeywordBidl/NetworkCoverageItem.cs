using System.Runtime.Serialization;

namespace YD_API.Model.KeywordBidl
{
    [DataContract]
    public class NetworkCoverageItem
    {
        /// <summary> Частота показа (доля аудитории) в сетях. Указывается в процентах от 0 до 100. </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal Probability { get; set; }

        /// <summary> Ставка в сетях, соответствующая указанной частоте показа. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }
    }
}
