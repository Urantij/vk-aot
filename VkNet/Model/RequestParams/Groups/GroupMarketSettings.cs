using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// настройки блока товаров.
/// </summary>
[Serializable]
public class GroupMarketSettings
{
	/// <summary>
	/// Включен ли блок товаров
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Включены ли комментарии к товарам
	/// </summary>
	[JsonPropertyName("comments_enabled")]
	public bool? CommentsEnabled { get; set; }

	/// <summary>
	/// Включены ли сообщения сообщества
	/// </summary>
	[JsonPropertyName("can_message")]
	public bool? CanMessage { get; set; }

	/// <summary>
	/// Идентификаторы стран;
	/// </summary>
	[JsonPropertyName("country_ids")]
	public ReadOnlyCollection<long> CountryIds { get; set; }

	/// <summary>
	/// Идентификаторы городов
	/// </summary>
	[JsonPropertyName("city_ids")]
	public ReadOnlyCollection<long> CityIds { get; set; }

	/// <summary>
	/// Идентификатор контактного лица;
	/// </summary>
	[JsonPropertyName("contact_id")]
	public long? ContactId { get; set; }

	/// <summary>
	/// Объект, описывающий валюту.
	/// </summary>
	[JsonPropertyName("currency")]
	public Currency Currency { get; set; }
}