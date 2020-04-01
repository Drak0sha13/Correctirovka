using System.Runtime.Serialization;
using YD_API.Model.Enum;

namespace YD_API.Model.ClientI
{

    /// <summary> Настройки рекламодателя, допускающие только значения YES или NO. </summary>
    [DataContract]
    public class ClientSettingGetItem
    {
        /// <summary> Имя настройки </summary>
        [DataMember(EmitDefaultValue = false)]
        public ClientSettingGetEnum Option { get; set; }

        /// <summary> Значение настройки. </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Value { get; set; }
    }
}
