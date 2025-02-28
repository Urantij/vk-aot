using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Count Value
/// </summary>
[Serializable]
public class CountValue
{
	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Значение
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }
}