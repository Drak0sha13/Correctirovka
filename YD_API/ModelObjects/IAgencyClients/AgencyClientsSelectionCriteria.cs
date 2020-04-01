using System.Runtime.Serialization;
using API_Yandex_Direct.Model.Enum;
using YD_API.Model.Enum;

namespace YD_API.ModelObjects.IAgencyClients
{
	[DataContract]
	public class AgencyClientsSelectionCriteria
	{
		/// <summary> Отбирать клиентов с указанными логинами представителей. Не более 10 000 элементов в массиве. </summary>
		[DataMember(EmitDefaultValue = false)]
		public string[] Logins { get; set; }

		/// <summary> Отбирать клиентов по признаку нахождения в архиве: YES — архивные клиенты, NO — активные клиенты. </summary>
		[DataMember(EmitDefaultValue = false)]
		public YesNoEnum? Archived { get; set; }

	}
}
