using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Отметка пользователя
/// </summary>
[Serializable]
public class Checkin
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Идентификатор отметившегося пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Дата добавления отметки в формате unixtime;
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Географическая широта, заданная в градусах (от -90 до 90);
	/// </summary>
	[JsonPropertyName("latitude")]
	public decimal Latitude { get; set; }

	/// <summary>
	/// Географическая долгота, заданная в градусах (от -180 до 180);
	/// </summary>
	[JsonPropertyName("longitude")]
	public decimal Longitude { get; set; }

	/// <summary>
	/// Идентификатор места
	/// </summary>
	[JsonPropertyName("place_id")]
	public long PlaceId { get; set; }

	/// <summary>
	/// Текст сопроводительного сообщения;
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Расстояние от места до заданной точки.
	/// </summary>
	[JsonPropertyName("distance")]
	public long Distance { get; set; }

	/// <summary>
	/// Наименование места
	/// </summary>
	[JsonPropertyName("place_title")]
	public string PlaceTitle { get; set; }

	/// <summary>
	/// Идентификатор страны
	/// </summary>
	[JsonPropertyName("place_country")]
	public long PlaceCountry { get; set; }

	/// <summary>
	/// Идентификатор города
	/// </summary>
	[JsonPropertyName("place_city")]
	public long PlaceCity { get; set; }

	/// <summary>
	/// Адрес
	/// </summary>
	[JsonPropertyName("place_address")]
	public string PlaceAddress { get; set; }

	/// <summary>
	/// Тип места;
	/// </summary>
	[JsonPropertyName("place_type")]
	public long PlaceType { get; set; }

	/// <summary>
	/// URL адрес к иконке
	/// </summary>
	[JsonPropertyName("icon")]
	public Uri Icon { get; set; }
}