using System.Runtime.Serialization;
using YD_API.Model.Enum;

namespace YD_API.Model.ClientI
{
    /// <summary> Номер телефона пользователя Директа (до 255 символов). </summary>
    [DataContract]
    public class ClientRestrictionItem
    {
        /// <summary> Имя ограничения </summary>
        [DataMember(EmitDefaultValue = false)]
        public ClientRestrictionEnum Element { get; set; }

        /// <summary> Значение ограничения. </summary>
        [DataMember(EmitDefaultValue = false)]
        public int Value { get; set; }
    }
}
