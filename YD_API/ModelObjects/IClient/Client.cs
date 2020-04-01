using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.IClient
{
	public class ClientObject : ModelObject, IGet5<ClientParamsRequest, ClientResult5>
	{
		protected readonly ApiConnect5 apiConnect;

		public ClientObject(ApiConnect5 api)
		{
			apiConnect = api;
		}

		public override string Name => "clients";

		public Task<GetResult5<ClientResult5>> GetAsync()
		{
			return GetAsync(new ClientParamsRequest()
			{
				FieldNames = new[] {
					ClientFieldNamesEnum.Login, 
					ClientFieldNamesEnum.ClientId, 
					ClientFieldNamesEnum.ClientInfo}
			});
		}

		public Task<GetResult5<ClientResult5>> GetAsync(ClientParamsRequest request)
		{
			var req = new RequestObjectV5<ClientParamsRequest>()
			{
				Method = MethodEnum.Get,
				Params = request,
			};
			return apiConnect.RequestStreamApi<GetResult5<ClientResult5>>(req, this);
		}
	}

	public class ClientParamsRequest : ParamsRequest<ClientFieldNamesEnum> 
	{}
}
