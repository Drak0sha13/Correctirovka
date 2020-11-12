using System.Runtime.Serialization;
using YD_API.Model.Enum;

namespace YD_API.Model.BidModifierI
{
    /// <summary> Параметры корректировки ставок по региону показа. </summary>
    [DataContract]
    public class RegionalAdjustment : Adjustment
    {
        /// <summary> Идентификатор региона из справочника регионов. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long RegionId { get; set; }

        /// <summary> Включен или отключен набор корректировок по полу и возрасту. </summary>
        [DataMember(EmitDefaultValue = false)]
        public YesNoEnum Enabled { get; set; }
    }
}
