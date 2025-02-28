using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика по полу возрасту и городу
/// </summary>
[Serializable]
public class StatsSexAgeCities
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("impressions_rate")]
	public long ImpressionsRate { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("clicks_rate")]
	public long ClicksRate { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}