using System.Threading.Tasks;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects
{
	public interface IGet5<T, U> where T : ParamsRequest where U : Result5
	{
		Task<GetResult5<U>> GetAsync(T request);
	}

	public interface IGetU5<T, U> where T : ParamsRequest where U : Result5
	{
		Task<GetResult5<U>> GetAsync(string user, T request);
	}
}
