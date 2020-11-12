using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YD_API.Model.Enum;
using YD_API.Model.Infrastructure;

namespace YD_API.Model
{
	//public class Dictionaries
	//{
	//	/// <summary> Особые категории рекламируемых товаров и услуг.  </summary>
	//	public AdCategoriesItem[] AdCategories { get; set; }

	//	/// <summary> Ограничения на значения параметров.  </summary>
	//	public ConstantsItem<ConstantsEnum>[] Constants { get; set; }

	//	/// <summary> Курсы валют, валютные параметры и ограничения.  </summary>
	//	public CurrenciesItem[] Currencies { get; set; }

	//	/// <summary> Регионы.  </summary>
	//	public GeoRegionsItem[] GeoRegions { get; set; }

	//	/// <summary> Станции метрополитена (только для Москвы, Санкт-Петербурга и Киева).  </summary>
	//	public MetroStationsItem[] MetroStations { get; set; }

	//	/// <summary> Версии операционных систем для рекламы мобильных приложений.  </summary>
	//	public OperationSystemVersionsItem[] OperationSystemVersions { get; set; }

	//	/// <summary> Часовые пояса.  </summary>
	//	public TimeZonesItem[] TimeZones { get; set; }

	//	/// <summary> Внешние сети (SSP).  </summary>
	//	public SupplySidePlatformsItem[] SupplySidePlatforms { get; set; }

	//	/// <summary> Интересы к категориям мобильных приложений.  </summary>
	//	public InterestsItem[] Interests { get; set; }

	//	/// <summary> Социально-демографические характеристики и поведенческие признаки.  </summary>
	//	public AudienceCriteriaTypesItem[] AudienceCriteriaTypes { get; set; }

	//	/// <summary> Сегменты по социально-демографическим характеристикам и поведенческим признакам для таргетинга по профилю пользователя.  </summary>
	//	public AudienceDemographicProfilesItem[] AudienceDemographicProfiles { get; set; }

	//	/// <summary> Сегменты по интересам пользователя для таргетинга по профилю пользователя.  </summary>
	//	public AudienceInterestsItem[] AudienceInterests { get; set; }
	//}

	[DataContract]
	public class AdCategoriesItem
	{
		/// <summary> Обозначение особой категории (параметр объявления AdCategories).  </summary>
		[DataMember]
		public string AdCategory { get; set; }

		/// <summary> Краткое описание особой категории на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary> Текст предупреждения, автоматически добавляемого в объявление, на языке, указанном в запросе в HTTP-заголовке Accept-Language (см. раздел Предупреждения и возрастные ограничения в объявлениях помощи Директа).  </summary>
		[DataMember]
		public string Message { get; set; }
	}

	[DataContract]
	public class CurrenciesItem
	{
		/// <summary> Обозначение валюты (параметр кампании Currency).  </summary>
		[DataMember]
		public string Currency { get; set; }

		/// <summary> Наименование и значение валютного параметра.
		/// <remarks> Внимание.Все возвращаемые денежные значения представляют собой целые числа — результат умножения ставки или цены на 1 000 000.  </remarks></summary>
		[DataMember]
		public ConstantsItem<CurrencyConstantsEnum>[] Properties { get; set; }
	}

	[DataContract]
	public class GeoRegionsItem
	{
		/// <summary> Идентификатор региона.  </summary>
		[DataMember]
		public long GeoRegionId { get; set; }

		/// <summary> Название региона на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string GeoRegionName { get; set; }

		/// <summary> Тип региона: World, Continent, Region, Country, Administrative area, District, City, City district, Village.  </summary>
		[DataMember]
		public string GeoRegionType { get; set; }

		/// <summary> Идентификатор вышестоящего региона.  </summary>
		[DataMember]
		public long? ParentId { get; set; }
	}

	[DataContract]
	public class MetroStationsItem
	{
		/// <summary> Идентификатор региона.  </summary>
		[DataMember]
		public long GeoRegionId { get; set; }

		/// <summary> Идентификатор станции метрополитена (параметр виртуальной визитки MetroStationId).  </summary>
		[DataMember]
		public long MetroStationId { get; set; }

		/// <summary> Название станции (на русском языке).  </summary>
		[DataMember]
		public string MetroStationName { get; set; }
	}

	[DataContract]
	public class OperationSystemVersionsItem
	{
		/// <summary> Название операционной системы.  </summary>
		[DataMember]
		public string OsName { get; set; }

		/// <summary> Версия операционной системы.  </summary>
		[DataMember]
		public string OsVersion { get; set; }
	}

	[DataContract]
	public class TimeZonesItem
	{
		/// <summary> Обозначение часового пояса (параметр кампании TimeZone).  </summary>
		[DataMember]
		public string TimeZone { get; set; }

		/// <summary> Описание часового пояса на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string TimeZoneName { get; set; }

		/// <summary> Смещение от UTC в секундах.  </summary>
		[DataMember]
		public int UtcOffset { get; set; }
	}

	[DataContract]
	public class SupplySidePlatformsItem
	{
		/// <summary> Наименование внешней сети.  </summary>
		[DataMember]
		public string Title { get; set; }
	}

	[DataContract]
	public class InterestsItem
	{
		/// <summary> Идентификатор интереса к категории мобильных приложений.  </summary>
		[DataMember]
		public long InterestId { get; set; }

		/// <summary> Идентификатор вышестоящего интереса.  </summary>
		[DataMember]
		public long? ParentId { get; set; }

		/// <summary> Название интереса на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Name { get; set; }

		/// <summary> Признак того, что идентификатор интереса можно указывать в условии нацеливания на аудиторию.  </summary>
		[DataMember]
		public YesNoEnum IsTargetable { get; set; }
	}

	[DataContract]
	public class AudienceCriteriaTypesItem
	{
		/// <summary> Идентификатор социально-демографической характеристики или поведенческого признака.  </summary>
		[DataMember]
		public string Type { get; set; }

		/// <summary> Группа характеристик, к которой относится характеристика: </summary> 
		[DataMember]
		public BlockElementEnum BlockElement { get; set; }

		/// <summary> Название характеристики или признака на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Name { get; set; }

		/// <summary> Описание характеристики или признака на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary> Допустимо ли указать в правиле отбора пользователей все сегменты по данной характеристике или признаку (например, указать все возрастные группы нельзя, а все профессии можно).  </summary>
		[DataMember]
		public CanSelectEnum CanSelect { get; set; }
	}

	[DataContract]
	public class AudienceDemographicProfilesItem
	{
		/// <summary> Идентификатор сегмента по социально-демографической характеристике или поведенческому признаку.  </summary>
		[DataMember]
		public long Id { get; set; }

		/// <summary> Идентификатор социально-демографической характеристики или поведенческого признака (параметр Type структуры AudienceCriteriaTypes).  </summary>
		[DataMember]
		public string Type { get; set; }

		/// <summary> Название сегмента на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Name { get; set; }

		/// <summary> Описание сегмента на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Description { get; set; }
	}

	[DataContract]
	public class AudienceInterestsItem
	{
		/// <summary> Идентификатор интереса пользователя.  </summary>
		[DataMember]
		public long InterestKey { get; set; }

		/// <summary> Идентификатор сегмента по интересам пользователя.
		/// Идентификатор сегмента состоит из префикса, обозначающего тип интереса, и идентификатора интереса.Например, InterestKey равен 2499001182 (авиабилеты), а Id равен 102499001182 (краткосрочный интерес к авиабилетам).  </summary>
		[DataMember]
		public long Id { get; set; }

		/// <summary> Идентификатор вышестоящего сегмента.  </summary>
		[DataMember]
		public long ParentId { get; set; }

		/// <summary> Название сегмента на языке, указанном в запросе в HTTP-заголовке Accept-Language.  </summary>
		[DataMember]
		public string Name { get; set; }

		/// <summary> Описание сегмента на языке, указанном в запросе в HTTP-заголовке Accept-Language  </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary> Тип интереса: краткосрочный, долгосрочный или за любой период.  </summary>
		[DataMember]
		public InterestTypeEnum InterestType { get; set; }

	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum BlockElementEnum
	{
		/// <summary> пол, возраст, доход. </summary>
		SOCIAL,
		/// <summary> семейное положение, дети, профессия. </summary>
		EXTENDED_SOCIAL,    
		/// <summary> поведенческие признаки. </summary>
		BEHAVIORAL_INDICATORS
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum InterestTypeEnum
	{
		SHORT_TERM,
		LONG_TERM,
		ANY
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CanSelectEnum
	{
		ALL,
		EXCEPT_ALL
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CurrencyConstantsEnum
	{
		/// <summary> название валюты на языке, указанном в запросе в HTTP-заголовке Accept-Language; </summary>
		FullName,
		/// <summary> шаг торгов; </summary>
		BidIncrement,
		/// <summary> максимальная ставка за клик(техническое ограничение); </summary>
		MaximumBid,
		/// <summary> максимальная ставка или цена за тысячу показов для медийной рекламы; </summary>
		MaximumCPM,
		/// <summary> минимальный дневной бюджет общего счета. </summary>
		MinimumAccountDailyBudget,
		/// <summary> минимальное значение средней цены конверсии для стратегии AVERAGE_CPA, минимальное значение средней цены установки для стратегии AVERAGE_CPI; </summary>
		MinimumAverageCPA,
		/// <summary> минимальное значение средней цены клика для стратегий AVERAGE_CPC, WEEKLY_CLICK_PACKAGE; </summary>
		MinimumAverageCPC,
		/// <summary> минимальная ставка за клик; </summary>
		MinimumBid,
		/// <summary> минимальная ставка или цена за тысячу показов для медийной рекламы; </summary>
		MinimumCPM,
		/// <summary> минимальный дневной бюджет кампании; </summary>
		MinimumDailyBudget,
		/// <summary> минимальный платеж(без учета НДС); </summary>
		MinimumPayment,
		/// <summary> минимальная сумма перевода между кампаниями; </summary>
		MinimumTransferAmount,
		/// <summary> минимальный недельный бюджет. </summary>
		MinimumWeeklySpendLimit,
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ConstantsEnum
	{
		/// <summary> устарело, рекомендуем использовать MaximumTextAdTextLength.	 </summary>
		[Obsolete("устарело, рекомендуем использовать MaximumTextAdTextLength")]
		MaximumAdTextLength,
		/// <summary> максимальное количество символов в каждом слове в тексте объявления.	 </summary>
		MaximumAdTextWordLength,
		/// <summary> устарело, рекомендуем использовать MaximumTextAdTitleLength.	 </summary>
		[Obsolete("устарело, рекомендуем использовать MaximumTextAdTitleLength")]
		MaximumAdTitleLength,
		/// <summary> максимальное количество символов в каждом слове в заголовке объявления.	 </summary>
		MaximumAdTitleWordLength,
		/// <summary> максимальное количество символов в тексте динамического объявления без учета «узких».    </summary>
		MaximumDynamicTextAdTextLength,
		/// <summary> максимальное количество символов в тексте объявления для рекламы мобильных приложений.	 </summary>
		MaximumMobileAppAdTextLength,
		/// <summary> максимальное количество символов в заголовке объявления для рекламы мобильных приложений.    </summary>
		MaximumMobileAppAdTitleLength,
		/// <summary> максимальное количество «узких» символов в заголовке или в тексте объявления.	 </summary>
		MaximumNumberOfNarrowCharacters,
		/// <summary> максимальное количество символов в описании быстрой ссылки.	 </summary>
		MaximumSitelinkDescriptionLength,
		/// <summary> максимальное суммарное количество символов в текстах всех быстрых ссылок в наборе.	 </summary>
		MaximumSitelinksLength,
		/// <summary> максимальное количество быстрых ссылок в наборе.    </summary>
		MaximumSitelinksNumber,
		/// <summary> максимальное количество символов в тексте быстрой ссылки.	 </summary>
		MaximumSitelinkTextLength,
		/// <summary> максимальное количество символов в тексте текстово-графического объявления без учета «узких».    </summary>
		MaximumTextAdTextLength,
		/// <summary> максимальное количество символов в заголовке 1 текстово-графического объявления без учета «узких».    </summary>
		MaximumTextAdTitleLength,
		/// <summary> максимальное количество символов в заголовке 2 текстово-графического объявления без учета «узких».	 </summary>
		MaximumTextAdTitle2Length,
	}
}



