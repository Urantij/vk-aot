using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Статистика сообщества или приложения.
/// </summary>
[Serializable]
public class StatsPeriod
{
	/// <summary>
	/// Период начала отсчёта.
	/// </summary>
	[JsonPropertyName("period_from")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime PeriodFrom { get; set; }

	/// <summary>
	/// Период окончания отсчёта.
	/// </summary>
	[JsonPropertyName("period_to")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime PeriodTo { get; set; }

	/// <summary>
	/// Данные о посетителях и просмотрах.
	/// </summary>
	[JsonPropertyName("visitors")]
	public VisitorStats Visitors { get; set; }

	/// <summary>
	/// Данные об охвате.
	/// </summary>
	[JsonPropertyName("reach")]
	public ReachStats Reach { get; set; }

	/// <summary>
	/// Activity
	/// </summary>
	[JsonPropertyName("activity")]
	public Activity Activity { get; set; }
}