using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат таргетированной рекламы
/// </summary>
[Serializable]
public class AdsTargetingResult
{
	/// <summary>
	/// Идентификатор кампании.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Формат объявления
	/// </summary>
	[JsonPropertyName("campaign_id")]
	public string CampaignId { get; set; }

	/// <summary>
	/// Автоматическое управление ценой
	/// </summary>
	[JsonPropertyName("country")]
	public string Country { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("cities")]
	public string Cities { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("cities_not")]
	public string CitiesNot { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("count")]
	public string Count { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("statuses")]
	public string Statuses { get; set; }
}