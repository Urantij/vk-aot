using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Элемент статистики для стрима
/// </summary>
[Serializable]
public class StreamingStatsItem
{
	/// <summary>
	/// Время, соответствующее значению;
	/// </summary>
	[JsonPropertyName("timestamp")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Timestamp { get; set; }

	/// <summary>
	/// Значение
	/// </summary>
	[JsonPropertyName("value")]
	public int Value { get; set; }
}