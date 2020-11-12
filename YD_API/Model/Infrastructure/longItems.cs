using System.Runtime.Serialization;

namespace YD_API.Model.Infrastructure
{
    [DataContract]
    public struct LongItems
    {
        [DataMember(EmitDefaultValue = false)]
        public long[] Items { get; set; }
    }
}
