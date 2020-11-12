using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YD_API.ModelObjects;

namespace YD_API.ApiConnect
{
	public abstract class BaseApiConnect : IApiConnect
	{
		private string units = new Guid().ToString();
		protected HttpClient Client { get; }

		public BaseApiConnect(HttpClient client)
		{
			Client = client;
		}

		/// <summary> Units указано количество баллов: израсходовано при выполнении запроса / доступный остаток / суточный лимит. </summary>
		public string Units
		{
			get => units;
			set
			{
				units = value;
				NotifyDataChanged();
			}
		}

		public event Action OnChange;

		private void NotifyDataChanged() => OnChange?.Invoke();

		/// <summary> получаем ответ яндекс директ </summary>
		/// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
		/// <param name="obj">Объект в Яндекс директ, для запроса</param>
		/// <param name="headers">Заголовки запроса</param>
		/// <returns></returns>
		// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса. Заголовок допустим только в запросах от имени агентства.</param>
		protected async Task<T> RequestStreamApi<T>(object requestObj, ModelObject obj, params (string, string)[] headers)
		{
			string s = await RequestStreamApi(requestObj, obj.Name,  headers);
			return JsonConvert.DeserializeObject<T>(s);
		}

		/// <summary> получаем ответ яндекс директ </summary>
		/// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
		/// <param name="siteObject">Объект в Яндекс директ, для запроса</param>
		/// <param name="headers">Заголовки запроса</param>
		/// <returns></returns>
		// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса. Заголовок допустим только в запросах от имени агентства.</param>
		public async Task<string> RequestStreamApi(object requestObj, string siteObject, (string, string)[] headers)
		{
			HttpRequestMessage рttpWebRequest = GetHttpWebRequest(requestObj, siteObject, headers);

			using (HttpResponseMessage resp = await Client.SendAsync(рttpWebRequest, HttpCompletionOption.ResponseHeadersRead))
			{
				resp.EnsureSuccessStatusCode();

				if (resp.Headers.TryGetValues("Units", out IEnumerable<string> en))
				{
					Units = string.Join("", en);
				}


				return await resp.Content.ReadAsStringAsync();
			}

			//StreamReader myStreamReader = null;
			//myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
			//pageContent = myStreamReader.ReadToEnd();
			//myStreamReader.Close();

			//List<string> list = new List<string>();
			//foreach (var l in resp.Headers)
			//{
			//	list.Add(l.ToString() + " : " + resp.Headers[l.ToString()]);
			//}

			//list.Add("HttpStatusCode : " + resp.StatusCode.ToString());
			//Headers = list.ToArray();
			//Request request = new Request
			//{
			//	RequestId = resp.Headers["RequestId"],
			//	ClientLogin = resp.Headers["Client - Login"],
			//	Units = resp.Headers["Units"],
			//	RequestText = рttpWebRequest.Headers.ToString() + "   " + SetBodyRequest,
			//	ResponseText = resp.Headers.ToString() + "   " + pageContent
			//};

			//return pageContent;
		}

		/// <summary> Подготовека HttpWebRequest для запроса к Api </summary>
		/// <param name="requestObj">объект которые необходимо отправить RequestObjectV5 или RequestObjectV4</param>
		/// <param name="siteObject">Адрес по которому отправляется запрос</param>
		/// <param name="headers">Заголовки запроса</param>
		/// <returns></returns>
		// <param name="UseOperatorUnits">Use-Operator-Units: true  - Расходовать баллы агентства, а не рекламодателя при выполнении запроса. Заголовок допустим только в запросах от имени агентства.</param>
		protected HttpRequestMessage GetHttpWebRequest(object requestObj, string siteObject,
			(string key, string value)[] headers)
		{
			string body = JsonConvert.SerializeObject(requestObj);

			//string site = ConnectUrl(siteObject);

			HttpRequestMessage msg = CreateRequestMessage(siteObject);

			msg.Content = new StringContent(body, Encoding.UTF8, "application/json");

			//HttpResponseMessage рttpWebRequest = await Client.SendAsync(msg);

			//if (userRequest.loginClient != "")
			// рttpWebRequest.Headers.Add(string.Format("Client-Login:{0}", userRequest.loginClient));
			//if (UseOperatorUnits) 
			// рttpWebRequest.Headers.Add("Use-Operator-Units: true");

			foreach (var pair in headers)
				msg.Headers.Add(pair.Item1, pair.Item2);

			return msg;
		}

		protected virtual HttpRequestMessage CreateRequestMessage(string siteUnits)
        {
	        return new HttpRequestMessage(HttpMethod.Post, ConnectUrl(siteUnits));
        }

        /// <summary> Строка подключения к api
        /// <param name="siteUnits">требуемый обект в запросе</param> </summary>
        protected abstract string ConnectUrl(string siteUnits);
	}
}
