using System.Runtime.Serialization;

namespace YD_API.ApiConnect
{
    [DataContract]
    public abstract class Result5
    {
        /// <summary> Порядковый номер последнего возвращенного объекта. Передается в случае, если количество объектов в ответе было ограничено лимитом.  </summary>
        [DataMember(EmitDefaultValue = false)]
        public long LimitedBy { get; set; }
    }

    [DataContract]
    public abstract class Result5<T> : Result5 where T : BaseModel
    {
        public virtual T[] Models { get; set; }

    }
}