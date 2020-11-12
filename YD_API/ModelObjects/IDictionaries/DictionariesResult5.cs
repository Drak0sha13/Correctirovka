using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using YD_API.ApiConnect;
using YD_API.Model;
using YD_API.Model.Infrastructure;

namespace YD_API.ModelObjects.IDictionaries
{
	[DataContract]
	public class DictionariesResult5 : Result5
	{
		/// <summary> Особые категории рекламируемых товаров и услуг.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public AdCategoriesItem[] AdCategories { get; set; }

		/// <summary> Ограничения на значения параметров.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public ConstantsItem<ConstantsEnum>[] Constants { get; set; }

		/// <summary> Курсы валют, валютные параметры и ограничения.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public CurrenciesItem[] Currencies { get; set; }

		/// <summary> Регионы.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public GeoRegionsItem[] GeoRegions { get; set; }

		/// <summary> Станции метрополитена (только для Москвы, Санкт-Петербурга и Киева).  </summary>
		[DataMember(EmitDefaultValue = false)]
		public MetroStationsItem[] MetroStations { get; set; }

		/// <summary> Версии операционных систем для рекламы мобильных приложений.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public OperationSystemVersionsItem[] OperationSystemVersions { get; set; }

		/// <summary> Часовые пояса.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public TimeZonesItem[] TimeZones { get; set; }

		/// <summary> Внешние сети (SSP).  </summary>
		[DataMember(EmitDefaultValue = false)]
		public SupplySidePlatformsItem[] SupplySidePlatforms { get; set; }

		/// <summary> Интересы к категориям мобильных приложений.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public InterestsItem[] Interests { get; set; }

		/// <summary> Социально-демографические характеристики и поведенческие признаки.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public AudienceCriteriaTypesItem[] AudienceCriteriaTypes { get; set; }

		/// <summary> Сегменты по социально-демографическим характеристикам и поведенческим признакам для таргетинга по профилю пользователя.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public AudienceDemographicProfilesItem[] AudienceDemographicProfiles { get; set; }

		/// <summary> Сегменты по интересам пользователя для таргетинга по профилю пользователя.  </summary>
		[DataMember(EmitDefaultValue = false)]
		public AudienceInterestsItem[] AudienceInterests { get; set; }
	}
}
