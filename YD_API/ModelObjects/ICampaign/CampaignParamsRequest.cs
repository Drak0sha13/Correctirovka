using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YD_API.ApiConnect;

namespace YD_API.ModelObjects.ICampaign
{
	public class CampaignParamsRequest : PageParamsRequest<CampaignFieldNamesEnum>
	{
        /// <summary> Критерий отбора кампаний.
        ///<para>Чтобы получить все кампании рекламодателя, необходимо указать пустой SelectionCriteria.</para>  </summary>
        [DataMember]
        public CampaignsSelectionCriteria SelectionCriteria { get; set; }

        /// <summary> Имена параметров кампании с типом «Текстово-графические объявления»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа,
        /// параметры из TextCampaignFieldNames не возвращаются.</para>  </summary>
        [DataMember(EmitDefaultValue = false)]
        public TextCampaignFieldNamesList[] TextCampaignFieldNames { get; set; }

        /// <summary> Имена параметров кампании с типом «Реклама мобильных приложений»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа, 
        /// параметры из MobileAppCampaignFieldNames не возвращаются.</para>  </summary>
        [DataMember(EmitDefaultValue = false)]
        public MobileAppCampaignFieldNamesList[] MobileAppCampaignFieldNames { get; set; }

        /// <summary> Имена параметров кампании с типом «Динамические объявления»
        ///<para>Примечание. Если согласно SelectionCriteria отобрана кампания другого типа, 
        ///параметры из DynamicTextCampaignFieldNames не возвращаются.</para>  </summary>
        [DataMember(EmitDefaultValue = false)]
        public DynamicTextCampaignFieldNamesList[] DynamicTextCampaignFieldNames { get; set; }
	}
	/// <summary>  Перечень доступных полей для запросов </summary>   
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextCampaignFieldNamesList { CounterIds, RelevantKeywords, Settings, BiddingStrategy }

	/// <summary> Перечень доступных полей для запросов </summary>       
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MobileAppCampaignFieldNamesList { Settings, BiddingStrategy }

    /// <summary> Перечень доступных полей для запросов </summary>       
    [JsonConverter(typeof(StringEnumConverter))]
	public enum DynamicTextCampaignFieldNamesList { CounterIds, Settings, BiddingStrategy }
}
