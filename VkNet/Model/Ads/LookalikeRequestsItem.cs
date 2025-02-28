using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект-запроса на поиск похожей аудитории.
/// </summary>
[Serializable]
public class LookalikeRequestItem
{
	/// <summary>
	/// Идентификатор запроса на поиск похожей аудитории.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип источника исходной аудитории для поиска похожей аудитории.
	/// </summary>
	[JsonPropertyName("source_type")]
	public SourceType? SourceType { get; set; }

	/// <summary>
	/// Время создания объявления
	/// </summary>
	[JsonPropertyName("create_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Время последнего изменения объявления
	/// </summary>
	[JsonPropertyName("update_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? UpdateTime { get; set; }

	/// <summary>
	/// Cтатус объявления.
	/// </summary>
	[JsonPropertyName("status")]
	public AdRequestStatus? Status { get; set; }

	/// <summary>
	/// Дата запланированного удаления запроса.
	/// </summary>
	[JsonPropertyName("scheduled_delete_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? ScheduledDeleteTime { get; set; }

	/// <summary>
	/// Идентификатор аудитории ретаргетинга с исходной аудиторией.
	/// </summary>
	[JsonPropertyName("source_retargeting_group_id")]
	public long? SourceRetargetingGroupId { get; set; }

	/// <summary>
	/// Имя источника исходной аудитории.
	/// </summary>
	[JsonPropertyName("source_name")]
	public string SourceName { get; set; }

	/// <summary>
	/// Размер исходной аудитории.
	/// </summary>
	[JsonPropertyName("audience_count")]
	public long AudienceCount { get; set; }

	/// <summary>
	/// Список доступных размеров аудитории для сохранения.
	/// </summary>
	[JsonPropertyName("save_audience_levels")]
	public ReadOnlyCollection<SaveAudienceLevels> SaveAudienceLevels { get; set; }
}