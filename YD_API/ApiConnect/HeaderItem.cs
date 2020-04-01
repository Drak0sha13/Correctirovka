using System;
using System.Collections.Generic;
using System.Text;

namespace YD_API.ApiConnect
{
	public class HeaderItem
	{
		public virtual string Key { get; set; }
		public string Value { get; set; }

		public static implicit operator (string, string)(HeaderItem item)
		{
			return (item.Key, item.Value);
		}
	}

	public class UserHeader : HeaderItem
	{
		public UserHeader(string user)
		{
			Value = user;
		}
		public override string Key => "Client-Login";
	}
}
