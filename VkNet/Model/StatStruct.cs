using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Структура статистики
/// </summary>
[Serializable]
public class StatsStruct
{
	/// <summary>
	/// Аудитория для показателя value;.
	/// </summary>
	[JsonPropertyName("visitors")]
	public long Visitors { get; set; }

	/// <summary>
	/// Значение демографического показателя, имеет разные возможные значения для
	/// разных показателей.
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }

	/// <summary>
	/// Код страны.
	/// </summary>
	[JsonPropertyName("code")]
	public string Code { get; set; }

	/// <summary>
	/// Наглядное название значения указанного в value (только для городов).
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}