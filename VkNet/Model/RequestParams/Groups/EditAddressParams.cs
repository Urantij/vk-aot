using System;
using System.Text.Json.Serialization;
using VkNet.Abstractions;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода <see cref="IGroupsCategory"/>.<see cref="IGroupsCategoryAsync.EditAddressAsync"/>
/// </summary>
[Serializable]
public class EditAddressParams
{
	/// <summary>
	/// Идентификатор сообщества, в которое добавляется адрес.
	/// </summary>
	/// <remarks>
	/// Положительное число, обязательный параметр
	/// </remarks>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Идентификатор адреса
	/// </summary>
	/// <remarks>
	/// Положительное число, обязательный параметр
	/// </remarks>
	[JsonPropertyName("address_id")]
	public ulong AddressId { get; set; }

	/// <summary>
	/// Заголовок адреса строка, максимальная длина 255
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Строка адреса
	/// </summary>
	/// <example>
	/// Невский проспект, дом 28
	/// </example>
	/// <remarks>
	/// Строка, максимальная длина 255
	/// </remarks>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Дополнительное описание адреса.
	/// </summary>
	/// <example>
	/// Второй этаж, налево
	/// </example>
	/// <remarks>
	/// Строка, максимальная длина 400
	/// </remarks>
	[JsonPropertyName("additional_address")]
	public string AdditionalAddress { get; set; }

	/// <summary>
	/// Номер телефона
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	/// <summary>
	/// Тип расписания.
	/// </summary>
	[JsonPropertyName("work_info_status")]
	public ScheduleWorkInfoStatus? WorkInfoStatus { get; set; }

	/// <summary>
	/// Идентификатор  страны.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetCountriesAsync"/> положительное число, минимальное значение 0
	/// </remarks>
	[JsonPropertyName("country_id")]
	public ulong CountryId { get; set; }

	/// <summary>
	/// Идентификатор города.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetCitiesAsync"/> положительное число, минимальное значение 0
	/// </remarks>
	[JsonPropertyName("city_id")]
	public ulong CityId { get; set; }

	/// <summary>
	/// Идентификатор станции метро.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetMetroStationsAsync"/> положительное число, минимальное значение 0
	/// </remarks>
	[JsonPropertyName("metro_id")]
	public ulong MetroId { get; set; }

	/// <summary>
	/// Географическая широта отметки, заданная в градусах (от -90 до 90). дробное число, минимальное значение -90, максимальное значение 90
	/// </summary>
	[JsonPropertyName("latitude")]
	public decimal Latitude { get; set; }

	/// <summary>
	/// Географическая долгота отметки, заданная в градусах (от -180 до 180). дробное число, минимальное значение -180, максимальное значение 180
	/// </summary>
	[JsonPropertyName("longitude")]
	public decimal Longitude { get; set; }

	/// <summary>
	/// Для типа timetable можно передать расписание в формате json.
	/// </summary>
	[JsonPropertyName("timetable")]
	public Timetable Timetable { get; set; }

	/// <summary>
	/// Установить адрес основным. Информация об основном адресе сразу показывается в сообществе.
	/// Для получения информации об остальных адресах нужно перейти к списку адресов. флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("is_main_address")]
	public bool IsMainAddress { get; set; }
}