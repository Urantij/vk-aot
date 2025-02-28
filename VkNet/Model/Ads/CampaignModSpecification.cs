using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Массив объектов CampaignModSpecification
/// </summary>
[Serializable]
public class CampaignModSpecification
{
	/// <summary>
	/// Идентификатор кампании.
	/// </summary>
	[JsonPropertyName("campaign_id")]
	public long CampaignId { get; set; }

	/// <summary>
	/// Название рекламной кампании.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[JsonPropertyName("status")]
	public AdStatus Status { get; set; }

	/// <summary>
	/// Общий лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("all_limit")]
	public long AllLimit { get; set; }

	/// <summary>
	/// Дневной лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("day_limit")]
	public long DayLimit { get; set; }

	/// <summary>
	/// Время создания объявления
	/// </summary>
	[JsonPropertyName("start_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? StartTime { get; set; }

	/// <summary>
	/// Время последнего изменения объявления
	/// </summary>
	[JsonPropertyName("stop_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? StopTime { get; set; }
}