using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Streaming Stats
/// </summary>
[Serializable]
public class StreamingStats
{
	/// <summary>
	/// Тип событий
	/// </summary>
	[JsonPropertyName("event_type")]
	public StreamingEventType? EventType { get; set; }

	/// <summary>
	/// Значения статистики
	/// </summary>
	[JsonPropertyName("stats")]
	public ReadOnlyCollection<StreamingStatsItem> Stats { get; set; }
}