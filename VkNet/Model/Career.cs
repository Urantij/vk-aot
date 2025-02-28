using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о карьере пользователя.
/// </summary>
[Serializable]
public class Career
{
	/// <summary>
	/// Идентификатор сообщества (если доступно, иначе company).
	/// </summary>
	[JsonPropertyName("group_id")]
	public long? GroupId { get; set; }

	/// <summary>
	/// Название организации (если доступно, иначе group_id).
	/// </summary>
	[JsonPropertyName("company")]
	public string Company { get; set; }

	/// <summary>
	/// Идентификатор страны.
	/// </summary>
	[JsonPropertyName("country_id")]
	public long? CountryId { get; set; }

	/// <summary>
	/// Идентификатор города (если доступно, иначе city_name).
	/// </summary>
	[JsonPropertyName("city_id")]
	public long? CityId { get; set; }

	/// <summary>
	/// Название города (если доступно, иначе city_id).
	/// </summary>
	[JsonPropertyName("city_name")]
	public string CityName { get; set; }

	/// <summary>
	/// Год начала работы.
	/// </summary>
	[JsonPropertyName("from")]
	public int? From { get; set; }

	/// <summary>
	/// Год окончания работы.
	/// </summary>
	[JsonPropertyName("until")]
	public ulong? Until { get; set; }

	/// <summary>
	/// Должность.
	/// </summary>
	[JsonPropertyName("position")]
	public string Position { get; set; }
}