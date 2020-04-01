using System.Runtime.Serialization;

namespace YD_API.ApiConnect
{
    /// <summary> Ошибки выполнения запроса </summary>
    [DataContract]
    public class GetResultError
    {
        /// <summary> Порядковый номер последнего возвращенного объекта. Передается в случае, если количество объектов в ответе было ограничено лимитом.  </summary>
        [DataMember(EmitDefaultValue = false)]
        public long LimitedBy { get; set; }

        /// <summary> Уникальный идентификатор запроса, присвоенный сервером API Директа.Также передается в HTTP-заголовке RequestId. </summary>
        [DataMember(Name = "request_id")]
        public string RequestId { get; set; }

        /// <summary> Числовой код ошибки. </summary>
        [DataMember(Name = "error_code")]
        public int ErrorCode { get; set; }

        /// <summary> Текст сообщения об ошибке. </summary>
        [DataMember(Name = "error_string")]
        public string ErrorString { get; set; }

        /// <summary> Подробное описание ошибки. </summary>
        [DataMember(Name = "error_detail")]
        public string ErrorDetail { get; set; }

    }
}
