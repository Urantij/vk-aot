using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса LinkStats
/// </summary>
[Serializable]
public class LinkStatsParams
{
	/// <summary>
	/// Сокращенная ссылка (часть URL после "vk.cc/").
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Ключ доступа к приватной статистике ссылки.
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }

	/// <summary>
	/// Единица времени для подсчета статистики.
	/// </summary>
	[JsonPropertyName("interval")]
	public LinkStatInterval? Interval { get; set; }

	/// <summary>
	/// Длительность периода для получения статистики в выбранных единицах (из
	/// параметра interval).
	/// </summary>
	[JsonPropertyName("intervals_count")]
	public uint IntervalsCount { get; set; }

	/// <summary>
	/// 1 — возвращать расширенную статистику (пол/возраст/страна/город),
	/// 0 — возвращать только количество переходов.
	/// </summary>
	[JsonPropertyName("extended")]
	public bool? Extended { get; set; }
}