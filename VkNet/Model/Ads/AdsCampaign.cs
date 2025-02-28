using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Возвращает список кампаний рекламного кабинета.
/// </summary>
/// <remarks>
/// См. описание https://vk.com/dev/ads.getCampaigns
/// </remarks>
[Serializable]
public class AdsCampaign
{
	/// <summary>
	/// Идентификатор рекламного кабинета.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип кампании
	/// </summary>
	[JsonPropertyName("type")]
	public CampaignType? Type { get; set; }

	/// <summary>
	/// Название кампании
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Статус кампании
	/// </summary>
	[JsonPropertyName("status")]
	[JsonConverter(converterType: typeof(JsonStringEnumConverter<CampaignStatus>))]
    public CampaignStatus Status { get; set; }

	/// <summary>
	/// Дневной лимит кампании в рублях
	/// </summary>
	[JsonPropertyName("day_limit")]
	public int DayLimit { get; set; }

	/// <summary>
	/// Общий лимит кампании в рублях
	/// </summary>
	[JsonPropertyName("all_limit")]
	public int AllLimit { get; set; }

	/// <summary>
	/// Время запуска кампании в формате unixtime
	/// </summary>
	[JsonPropertyName("start_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? StartTime { get; set; }

	/// <summary>
	/// Время запуска кампании в формате unixtime
	/// </summary>
	[JsonPropertyName("stop_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? StopTime { get; set; }

	/// <summary>
	/// Время создания кампании в формате unixtime
	/// </summary>
	[JsonPropertyName("create_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Время последнего изменения кампании в формате unixtime
	/// </summary>
	[JsonPropertyName("update_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? UpdateTime { get; set; }
}