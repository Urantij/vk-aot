using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Параметры метода Stats.Get
/// </summary>
[Serializable]
public class StatsGetParams
{
	/// <summary>
	/// Идентификатор сообщества.
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Идентификатор приложения.
	/// </summary>
	[JsonPropertyName("app_id")]
	public ulong AppId { get; set; }

	/// <summary>
	/// Начало периода статистики в Unixtime.
	/// </summary>
	/// <remarks>
	/// Положительное число, доступен начиная с версии 5.86
	/// </remarks>
	[JsonPropertyName("timestamp_from")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? TimestampFrom { get; set; }

	/// <summary>
	/// Окончание периода статистики в Unixtime.
	/// </summary>
	/// <remarks>
	/// Положительное число, доступен начиная с версии 5.86
	/// </remarks>
	[JsonPropertyName("timestamp_to")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? TimestampTo { get; set; }

	/// <summary>
	/// Временные интервалы.
	/// </summary>
	[JsonPropertyName("interval")]
	public StateInterval? Interval { get; set; }

	/// <summary>
	/// Количество интервалов времени.
	/// </summary>
	[JsonPropertyName("intervals_count")]
	public ulong IntervalsCount { get; set; }

	/// <summary>
	/// Список фильтров
	/// </summary>
	[JsonPropertyName("filters")]
	public ReadOnlyCollection<string> Filters { get; set; }

	/// <summary>
	/// Фильтр для получения данных по конкретному блоку статистики сообщества.
	/// </summary>
	[JsonPropertyName("stats_groups")]
	public StatsGroups? StatsGroups { get; set; }

	/// <summary>
	/// 1 — возвращать дополнительно агрегированные данные в результатах.
	/// </summary>
	[JsonPropertyName("extended")]
	public bool? Extended { get; set; }

	/// <summary>
	/// Начальная дата выводимой статистики в формате YYYY-MM-DD.
	/// </summary>
	[JsonPropertyName("date_from")]
	[DateTimeToStringFormat("yyyy-MM-dd")]
	[Obsolete(ObsoleteText.StatsGet)]
	public DateTime DateFrom { get; set; }

	/// <summary>
	/// Конечная дата выводимой статистики в формате YYYY-MM-DD.
	/// </summary>
	[JsonPropertyName("date_to")]
	[DateTimeToStringFormat("yyyy-MM-dd")]
	[Obsolete(ObsoleteText.StatsGet)]
	public DateTime DateTo { get; set; }
}