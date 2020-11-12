using System.Runtime.Serialization;
using System.Threading.Tasks;
using YD_API.ApiConnect;
using YD_API.ModelObjects.IClient;

namespace YD_API.ModelObjects.IAgencyClients
{
	public class AgencyClientsObject : ModelObject, IGet5<AgencyClientsParamsRequest, ClientResult5>
	{
		protected readonly ApiConnect5 apiConnect;

		public AgencyClientsObject(ApiConnect5 api)
		{
			apiConnect = api;
		}

		public override string Name => "agencyclients";

		public Task<GetResult5<ClientResult5>> GetAsync()
		{
			return GetAsync(new AgencyClientsParamsRequest()
			{
				FieldNames = new[]
				{
					ClientFieldNamesEnum.Login,
					ClientFieldNamesEnum.ClientId,
					ClientFieldNamesEnum.ClientInfo
				}
			});
		}

		public Task<GetResult5<ClientResult5>> GetAsync(AgencyClientsParamsRequest request)
		{
			var req = new RequestObjectV5<AgencyClientsParamsRequest>()
			{
				Method = MethodEnum.Get,
				Params = request,
			};
			return apiConnect.GetAsync<GetResult5<ClientResult5>>(req, this);
		}
	}

	[DataContract]
	public class AgencyClientsParamsRequest : PageParamsRequest<ClientFieldNamesEnum>
	{
		public AgencyClientsParamsRequest()
		{
			SelectionCriteria = new AgencyClientsSelectionCriteria();
		}
		/// <summary>Критерии отбора клиентов.
		///<para> Чтобы получить параметры всех клиентов агентства, необходимо указать пустую структуру SelectionCriteria.</para> </summary>
		[DataMember]
		public AgencyClientsSelectionCriteria SelectionCriteria { get; set; }
	}
}
