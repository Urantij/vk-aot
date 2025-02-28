using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат получения адреса
/// </summary>
[Serializable]
public class AddressResult
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Дополнительный адрес
	/// </summary>
	[JsonPropertyName("additional_address")]
	public string AdditionalAddress { get; set; }

	/// <summary>
	/// Основной адрес
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Идентификатор города
	/// </summary>
	[JsonPropertyName("city_id")]
	public long? CityId { get; set; }

	/// <summary>
	/// Идентификатор страны
	/// </summary>
	[JsonPropertyName("country_id")]
	public long? CountryId { get; set; }

	/// <summary>
	/// Широта
	/// </summary>
	[JsonPropertyName("latitude")]
	public double? Latitude { get; set; }

	/// <summary>
	/// Долгота
	/// </summary>
	[JsonPropertyName("longitude")]
	public double? Longitude { get; set; }

	/// <summary>
	/// Идентификатор станции метро
	/// </summary>
	[JsonPropertyName("metro_station_id")]
	public long? MetroStationId { get; set; }

	/// <summary>
	/// Телефон
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	/// <summary>
	/// Сдвиг по времени
	/// </summary>
	[JsonPropertyName("time_offset")]
	public long? TimeOffset { get; set; }

	/// <summary>
	/// Расписание
	/// </summary>
	[JsonPropertyName("timetable")]
	public Timetable Timetable { get; set; }

	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Информация о статусе работы
	/// </summary>
	[JsonPropertyName("work_info_status")]
	public string WorkInfoStatus { get; set; }
}