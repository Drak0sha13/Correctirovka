using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.ApiConnect;
using YD_API.Model;
using YD_API.ModelObjects.IDictionaries;

namespace Correctirovka.Data
{
	public class ClientSettings
	{
		private string _units;

		private Client _user;

		public ClientSettings(DictionariesObject cash)
		{
			Cash = cash;
		}

		//public IEnumerable<Client> SelectedItems { get; set; } = new Client[0];

		public string Units
		{
			get => _units;
			set
			{
				_units = value;
				NotifyDataChanged();
			}
		}

		public string UserName => User?.Login;

		public Client User
		{
			get => _user;
			set
			{
				_user = value; 
				NotifyDataChanged();
			}
		}

		public IEnumerable<long> Campaigns { get; set; } = new long[0];

		public IEnumerable<IdName> CampaignCash { get; set; } = new List<IdName>();
		public IEnumerable<IdName> RetargetingListCash { get; set; } = new List<IdName>();

		public DictionariesObject Cash { get; private set; }

		public event Action OnChange;

		private void NotifyDataChanged() => OnChange?.Invoke();
	}

	public class IdName
	{
		public long ID { get; set; }
		public string Name { get; set; }
	}
}
