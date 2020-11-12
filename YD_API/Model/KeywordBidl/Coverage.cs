using System.Runtime.Serialization;

namespace YD_API.Model.KeywordBidl
{
    [DataContract]
    public class Coverage
    {
        /// <summary> Массив ставок, соответствующих охвату различных долей аудитории. </summary>
        [DataMember(EmitDefaultValue = false)]
        public NetworkCoverageItem[] CoverageItems { get; set; }

    }
}
