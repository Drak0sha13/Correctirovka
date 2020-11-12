﻿using System.Runtime.Serialization;

namespace YD_API.Model.BidsI
{
    [DataContract]
    public class SearchPrices
    {
        /// <summary> Позиция показа на поиске </summary>
        [DataMember(EmitDefaultValue = false)]
        public PositionEnum Position { get; set; }

        /// <summary> Минимальная ставка за указанную позицию. </summary>
        [DataMember(EmitDefaultValue = false)]
        public long Price { get; set; }
    }
}
