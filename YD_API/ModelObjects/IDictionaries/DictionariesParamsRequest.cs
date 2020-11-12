using System;
using System.Collections.Generic;
using System.Text;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.IDictionaries
{
	public class DictionariesParamsRequest : ParamsRequest
	{
		/// <summary> Имена справочников, которые требуется получить. </summary>
		public DictionaryNameEnum[] DictionaryNames { get; set; }
    }
}
