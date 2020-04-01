using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace YD_API.ApiConnect
{
    [DataContract]
    public class RequestObjectV5<T>
    {
	    [DataMember(Name = "method")]
        public MethodEnum Method { get; set; }

        [DataMember(Name = "params", EmitDefaultValue = false)]
        public T Params { get; set; }
    }
}
