using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YD_API.ApiConnect
{
	public class ApiSettings
	{
		public ApiSettings()
		{
			UrlDirect = "api.direct.yandex.com";
		}

		public IEnumerable<string> ApiUrls { get; } = new List<string>()
		{
			"api.direct.yandex.com",
			"api-sandbox.direct.yandex.com",
		};

		/// <summary> OAuth-токен код, разрешающий доступ к данным конкретного пользователя. </summary>
		[Required]
		public string TokenApi { get; set; }

		/// <summary> Строка подключения к api </summary>
		[Required]
		public string UrlDirect { get; set; }
	}
}
