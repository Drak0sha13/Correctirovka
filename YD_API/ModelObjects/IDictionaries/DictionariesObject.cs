using System;
using System.Threading.Tasks;
using YD_API.ApiConnect;
using YD_API.Model;
using YD_API.Model.Infrastructure;

namespace YD_API.ModelObjects.IDictionaries
{
	public class DictionariesObject : ModelObject, IGet5<DictionariesParamsRequest, DictionariesResult5>
	{
		private readonly IServiceProvider _serviceProvider;
		private AdCategoriesItem[] _adCategories;
		private ConstantsItem<ConstantsEnum>[] _constants;
		private CurrenciesItem[] _currencies;
		private GeoRegionsItem[] _geoRegions;
		private MetroStationsItem[] _metroStations;
		private OperationSystemVersionsItem[] _operationSystemVersions;
		private TimeZonesItem[] _timeZones;
		private SupplySidePlatformsItem[] _supplySidePlatforms;
		private InterestsItem[] _interests;
		private AudienceCriteriaTypesItem[] _audienceCriteriaTypes;
		private AudienceDemographicProfilesItem[] _audienceDemographicProfiles;
		private AudienceInterestsItem[] _audienceInterests;

		public DictionariesObject(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider;
		}

		public override string Name => "dictionaries";

		/// <summary> Особые категории рекламируемых товаров и услуг.  </summary>
		public AdCategoriesItem[] AdCategories => _adCategories?? (_adCategories = Get(DictionaryNameEnum.AdCategories).AdCategories);

		/// <summary> Ограничения на значения параметров.  </summary>
		public ConstantsItem<ConstantsEnum>[] Constants => _constants ?? (_constants = Get(DictionaryNameEnum.Constants).Constants);

		/// <summary> Курсы валют, валютные параметры и ограничения.  </summary>
		public CurrenciesItem[] Currencies => _currencies ?? (_currencies = Get(DictionaryNameEnum.Currencies).Currencies);

		/// <summary> Регионы.  </summary>
		public GeoRegionsItem[] GeoRegions => _geoRegions ?? (_geoRegions = Get(DictionaryNameEnum.GeoRegions).GeoRegions);
		
		/// <summary> Станции метрополитена (только для Москвы, Санкт-Петербурга и Киева).  </summary>
		public MetroStationsItem[] MetroStations => _metroStations ?? (_metroStations = Get(DictionaryNameEnum.MetroStations).MetroStations);
		
		/// <summary> Версии операционных систем для рекламы мобильных приложений.  </summary>
		public OperationSystemVersionsItem[] OperationSystemVersions => _operationSystemVersions ?? (_operationSystemVersions = Get(DictionaryNameEnum.OperationSystemVersions).OperationSystemVersions);
		
		/// <summary> Часовые пояса.  </summary>
		public TimeZonesItem[] TimeZones => _timeZones ?? (_timeZones = Get(DictionaryNameEnum.TimeZones).TimeZones);
		
		/// <summary> Внешние сети (SSP).  </summary>
		public SupplySidePlatformsItem[] SupplySidePlatforms => _supplySidePlatforms ?? (_supplySidePlatforms = Get(DictionaryNameEnum.SupplySidePlatforms).SupplySidePlatforms);
		
		/// <summary> Интересы к категориям мобильных приложений.  </summary>
		public InterestsItem[] Interests => _interests ?? (_interests = Get(DictionaryNameEnum.Interests).Interests);
		
		/// <summary> Социально-демографические характеристики и поведенческие признаки.  </summary>
		public AudienceCriteriaTypesItem[] AudienceCriteriaTypes => _audienceCriteriaTypes ?? (_audienceCriteriaTypes = Get(DictionaryNameEnum.AudienceCriteriaTypes).AudienceCriteriaTypes);
		
		/// <summary> Сегменты по социально-демографическим характеристикам и поведенческим признакам для таргетинга по профилю пользователя.  </summary>
		public AudienceDemographicProfilesItem[] AudienceDemographicProfiles => _audienceDemographicProfiles ?? (_audienceDemographicProfiles = Get(DictionaryNameEnum.AudienceDemographicProfiles).AudienceDemographicProfiles);
		
		/// <summary> Сегменты по интересам пользователя для таргетинга по профилю пользователя.  </summary>
		public AudienceInterestsItem[] AudienceInterests => _audienceInterests ?? (_audienceInterests = Get(DictionaryNameEnum.AudienceInterests).AudienceInterests);

		protected ApiConnect5 ApiConnect => (ApiConnect5) _serviceProvider.GetService(typeof(ApiConnect5));

		protected virtual DictionariesResult5 Get(params DictionaryNameEnum[] dictionary)
		{
			GetResult5<DictionariesResult5> result = Task.Run(() => GetAsync(new DictionariesParamsRequest
			{
				DictionaryNames = dictionary
			})).Result;
			return result.Result;
		}


		public Task<GetResult5<DictionariesResult5>> GetAsync(DictionariesParamsRequest request)
		{
			var req = new RequestObjectV5<DictionariesParamsRequest>
			{
				Method = MethodEnum.Get,
				Params = request
			};
			return ApiConnect.GetAsync<GetResult5<DictionariesResult5>>(req, this);

		}
	}
}
