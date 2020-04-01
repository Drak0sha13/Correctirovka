using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using API_Yandex_Direct.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YD_API.ApiConnect
{
    [DataContract]
    public class GetResult5<T> where T : Result5
    {
        [DataMember(Name = "result")]
        public T Result { get; set; }

        [DataMember(Name = "error")] 
        public GetResultError Error { get; set; }

    }
}
