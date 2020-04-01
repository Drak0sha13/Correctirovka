using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YD_API.ModelObjects.IClient
{
    /// <summary> Перечень доступных полей для запросов </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientFieldNamesEnum : byte
    {
        /// <summary> Показатель качества аккаунта </summary>
        AccountQuality,
        /// <summary> Признак того, что рекламодатель помещен в архив (не активен). </summary>
        Archived,
        /// <summary> Идентификатор рекламодателя. </summary>
        ClientId,
        /// <summary> ФИО пользователя Директа. </summary>
        ClientInfo,
        /// <summary> Идентификатор страны рекламодателя из справочника регионов. </summary>
        CountryId,
        /// <summary> Дата регистрации пользователя в Директе, в формате YYYY-MM-DD. </summary>
        CreatedAt,
        /// <summary> Валюта рекламодателя. </summary>
        Currency,
        /// <summary> Полномочия рекламодателя по управлению кампаниями. </summary>
        Grants,
        /// <summary> Логин пользователя Директа. </summary>
        Login,
        /// <summary> Настройки SMS- и email-уведомлений пользователя Директа. </summary>
        Notification,
        /// <summary> Лимит овердрафта, которым рекламодатель может воспользоваться в текущий момент времени </summary>
        OverdraftSumAvailable,
        /// <summary> Номер телефона пользователя Директа. </summary>
        Phone,
        /// <summary> Представители рекламодателя. </summary>
        Representatives,
        /// <summary> Количественные ограничения на объекты рекламодателя. </summary>
        Restrictions,
        /// <summary> Настройки рекламодателя. </summary>
        Settings,
        /// <summary> Тип клиента. </summary>
        Type,
        /// <summary> Ставка НДС клиента, осуществляющего оплату: прямого рекламодателя или агентства. </summary>
        VatRate
    };
}
