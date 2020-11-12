using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using YD_API.ModelObjects;

namespace YD_API.ApiConnect
{
	public class ApiConnect5 : BaseApiConnect
	{
		private readonly ApiSettings _settings;

		public ApiConnect5(HttpClient client, ApiSettings settings) : base(client)
		{
			_settings = settings;
			Client.BaseAddress = new Uri($"https://{_settings.UrlDirect}");
			Client.DefaultRequestHeaders.AcceptLanguage.Add(new StringWithQualityHeaderValue("ru"));
		}

		/// <inheritdoc />
		protected override string ConnectUrl(string siteUnits)
		{
			return $"/json/v5/{siteUnits}";
		}

		public async Task<T> GetAsync<T>(object requestObj, ModelObject obj, params (string, string)[] headers) where T : GetResult5, new()
		{
			try
			{
				return await base.RequestStreamApi<T>(requestObj, obj, headers);
			}
			catch (Exception ex)
			{
				T t = new T
				{
					Error = new GetResultError()
					{
						ErrorString = "Внутренняя ошибка", 
						ErrorCode = ex.HResult, 
						ErrorDetail = ex.Message,
					}
				};
				return t;
			}
		}

		protected override HttpRequestMessage CreateRequestMessage(string siteUnits)
		{
			HttpRequestMessage message = base.CreateRequestMessage(siteUnits);
			message.Headers.Add("Authorization", $"Bearer {_settings.TokenApi}");
			return message;
		}
	}
}
