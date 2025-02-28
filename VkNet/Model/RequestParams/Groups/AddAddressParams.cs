using System;
using System.Text.Json.Serialization;
using VkNet.Abstractions;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода <see cref="IGroupsCategory"/>.<see cref="IGroupsCategoryAsync.AddAddressAsync"/>
/// </summary>
[Serializable]
public class AddAddressParams
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
	/// Заголовок адреса строка, обязательный параметр, максимальная длина 255
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Строка адреса Невский проспект, дом 28 строка, обязательный параметр, максимальная длина 255
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Дополнительное описание адреса.
	/// </summary>
	/// <example>
	/// Второй этаж, налево строка, максимальная длина 400
	/// </example>
	[JsonPropertyName("additional_address")]
	public string AdditionalAddress { get; set; }

	/// <summary>
	/// Идентификатор  страны.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetCountriesAsync"/> положительное число,
	/// обязательный параметр, минимальное значение 1
	/// </remarks>
	[JsonPropertyName("country_id")]
	public ulong CountryId { get; set; }

	/// <summary>
	/// Идентификатор города.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetCitiesAsync"/> положительное число,
	/// обязательный параметр, минимальное значение 1
	/// </remarks>
	[JsonPropertyName("city_id")]
	public ulong CityId { get; set; }

	/// <summary>
	/// Географическая широта отметки, заданная в градусах (от -90 до 90).
	/// </summary>
	/// <remarks>
	/// Дробное число, обязательный параметр, минимальное значение -90, максимальное значение 90
	/// </remarks>
	[JsonPropertyName("latitude")]
	public double Latitude { get; set; }

	/// <summary>
	/// Географическая долгота отметки, заданная в градусах (от -180 до 180).
	/// </summary>
	/// <remarks>
	/// Дробное число, обязательный параметр, минимальное значение -180, максимальное значение 180
	/// </remarks>
	[JsonPropertyName("longitude")]
	public double Longitude { get; set; }

	/// <summary>
	/// Номер телефона строка
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	/// <summary>
	/// Тип расписания.
	/// </summary>
	[JsonPropertyName("work_info_status")]
	public ScheduleWorkInfoStatus? WorkInfoStatus { get; set; }

	/// <summary>
	/// Идентификатор станции метро.
	/// </summary>
	/// <remarks>
	/// Для получения можно использовать <see cref="IDatabaseCategory"/>.<see cref="IDatabaseCategoryAsync.GetMetroStationsAsync"/>
	/// положительное число, минимальное значение 0
	/// </remarks>
	[JsonPropertyName("metro_id")]
	public ulong? MetroId { get; set; }

	/// <summary>
	/// Для типа timetable можно передать расписание в формате json.
	/// Время передается в минутах от 0 часов.
	/// Ключ по дню означает, что день рабочий. open_time, close_time - начало и конец рабочего дня. break_open_time, break_close_time —  время перерыва.
	/// </summary>
	[JsonPropertyName("timetable")]
	public Timetable Timetable { get; set; }

	/// <summary>
	/// Установить адрес основным. Информация об основном адресе сразу показывается в сообществе.
	/// Для получения информации об остальных адресах нужно перейти к списку адресов.
	/// </summary>
	[JsonPropertyName("is_main_address")]
	public bool? IsMainAddress { get; set; }
}