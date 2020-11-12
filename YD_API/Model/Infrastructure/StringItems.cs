using System.Runtime.Serialization;

namespace YD_API.Model.Infrastructure
{
    [DataContract]
    public struct StringItems
    {
        [DataMember(EmitDefaultValue = false)]
        public string[] Items { get; set; }
    }
}
