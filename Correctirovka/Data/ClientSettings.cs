using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YD_API.Model;

namespace Correctirovka.Data
{
	public class ClientSettings
	{
		private string _units;
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

		public Client User { get; set; }

		public IEnumerable<long> Campaigns { get; set; } = new long[0];

		public event Action OnChange;

		private void NotifyDataChanged() => OnChange?.Invoke();
	}
}
