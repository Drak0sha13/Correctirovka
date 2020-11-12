using System.Runtime.Serialization;

namespace YD_API.Model.KeywordBidl
{
    [DataContract]
    public class AuctionBids
    {
        /// <summary> Массив ставок и списываемых цен на поиске, соответствующих различным объемам трафика. </summary>
        [DataMember(EmitDefaultValue = false)]
        public AuctionBidItem[] AuctionBidItems { get; set; }
    }
}
