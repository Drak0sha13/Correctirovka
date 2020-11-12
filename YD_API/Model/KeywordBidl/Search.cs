using System.Runtime.Serialization;

namespace YD_API.Model.KeywordBidl
{
    [DataContract]
   public class Search
    {
        /// <summary> Ставка на поиске, назначенная рекламодателем. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Bid { get; set; }

        /// <summary> Ставки и списываемые цены на поиске, соответствующие различным объемам трафика для данной фразы.
        /// <para>Если в группе только графические объявления, возвращается null (nil).</para>
        /// <para>Если в группе объявлений мало показов (значение RARELY_SERVED параметра ServingStatus), возвращается null (nil).</para>
        /// <para>Для автотаргетинга возвращается null (nil).</para> </summary>
        [DataMember(EmitDefaultValue = false)]
        public AuctionBids AuctionBids { get; set; }
    }
}
