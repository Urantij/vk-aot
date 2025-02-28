using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса places.checkins
/// </summary>
[Serializable]
public class PlacesGetCheckinsParams
{
	/// <summary>
	/// географическая широта точки, в радиусе которой необходимо производить поиск,
	/// заданная в градусах (от -90 до 90).
	/// </summary>
	[JsonPropertyName("latitude")]
	public decimal Latitude { get; set; }

	/// <summary>
	/// географическая долгота точки, в радиусе которой необходимо производить поиск,
	/// заданная в градусах (от -180 до 180).
	/// </summary>
	[JsonPropertyName("longitude")]
	public decimal Longitude { get; set; }

	/// <summary>
	/// идентификатор места. Игнорируется, если указаны latitude и longitude.
	/// </summary>
	[JsonPropertyName("place")]
	public ulong Place { get; set; }

	/// <summary>
	/// идентификатор пользователя. Игнорируется, если указаны latitude и longitude или
	/// place.
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// смещение относительно первой отметки для выборки определенного подмножества.
	/// Игнорируется, если установлен
	/// ненулевой timestamp.
	/// </summary>
	[JsonPropertyName("offset")]
	public ulong Offset { get; set; }

	/// <summary>
	/// количество возвращаемых отметок. Игнорируется, если установлен ненулевой
	/// timestamp.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// указывает, что нужно вернуть только те отметки, которые были созданы после
	/// заданного timestamp.
	/// </summary>
	[JsonPropertyName("timestamp")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Timestamp { get; set; }

	/// <summary>
	/// 1 — указывает, что следует выводить только отметки друзей, если заданы
	/// географические координаты.
	/// Игнорируется, если не заданы параметры latitude и longitude.
	/// </summary>
	[JsonPropertyName("friends_only")]
	public bool FriendsOnly { get; set; }

	/// <summary>
	/// указывает, следует ли возвращать информацию о месте в котором была сделана
	/// отметка.
	/// Игнорируется, если указан параметр place.
	/// </summary>
	[JsonPropertyName("need_places")]
	public bool NeedPlaces { get; set; }
}