using System.Runtime.Serialization;

namespace YD_API.Model.Infrastructure
{
	/// <summary> Ограничения на значения параметров. </summary>
	[DataContract]
	public class ConstantsItem<T> where T : struct
	{
		/// <summary> Наименование ограничения. </summary>
		[DataMember]
		public T Name { get; set; }

		/// <summary> Значение ограничения. </summary>
		[DataMember]
		public string Value { get; set; }
	}
}
