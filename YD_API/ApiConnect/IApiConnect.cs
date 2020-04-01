using System.Collections.Generic;
using System.Threading.Tasks;

namespace YD_API.ApiConnect
{
	public interface IApiConnect
	{
		string Units { get; set; }

		Task<string> RequestStreamApi(object requestObj, string siteObject, (string, string)[] headers);
	}
}