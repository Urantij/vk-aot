using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о месте, в котором была сделана запись.
/// См. описание <see href="http://vk.com/pages?oid=-1&amp;p=Описание_поля_geo" />
/// и http://vk.com/dev/fields_groups
/// </summary>
[Serializable]
public class Place
{
	/// <summary>
	/// Идентификатор места.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Название места.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Географическая широта, заданная в градусах (от -90 до 90).
	/// </summary>
	[JsonPropertyName("latitude")]
	public double? Latitude { get; set; }

	/// <summary>
	/// Географическая долгота, заданная в градусах (от -90 до 90).
	/// </summary>
	[JsonPropertyName("longitude")]
	public double? Longitude { get; set; }

	/// <summary>
	/// Идентификатор страны, название которой можно получить с помощью метода
	/// DatabaseCategory.GetCountriesById
	/// </summary>
	[JsonPropertyName("country_id")]
	public long? CountryId { get; set; }

	/// <summary>
	/// Идентификатор города, название которого можно получить с помощью метода
	/// DatabaseCategory.GetCitiesById
	/// </summary>
	[JsonPropertyName("city_id")]
	public long? CityId { get; set; }

	/// <summary>
	/// Строка с указанием адреса места в городе.
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Данный параметр указывается, если местоположение является прикреплённой картой.
	/// </summary>
	[JsonPropertyName("shop_map")]
	public bool? ShowMap { get; set; }

	/// <summary>
	/// Регистрации
	/// </summary>
	[JsonPropertyName("checkins")]
	public long? Checkins { get; set; }

	/// <summary>
	/// Дата создания
	/// </summary>
	[JsonPropertyName("created")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Created { get; set; }

	/// <summary>
	/// Дата и время последнего обновления
	/// </summary>
	[JsonPropertyName("updated")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Updated { get; set; }

	/// <summary>
	/// Тип
	/// </summary>
	[JsonPropertyName("type")]
	public long? Type { get; set; }

	/// <summary>
	/// Иконка
	/// </summary>
	[JsonPropertyName("icon")]
	public Uri Icon { get; set; }

	/// <summary>
	/// Страна, в которой находится место.
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; }

	/// <summary>
	/// Город, в котором находится место.
	/// </summary>
	[JsonPropertyName("city")]
	public string City { get; set; }

	/// <summary>
	/// Расстояние от исходной точки
	/// </summary>
	[JsonPropertyName("distance")]
	public long? Distance { get; set; }

	/// <summary>
	/// Идентификатор группы
	/// </summary>
	[JsonPropertyName("group_id")]
	public long? GroupId { get; set; }

	/// <summary>
	/// Ссылка на фото группы
	/// </summary>
	[JsonPropertyName("group_photo")]
	public Uri GroupPhoto { get; set; }

	[JsonPropertyName("place_id")]
	private long? PlaceId
	{
		get => Id;
		set => Id = value;
	}
}