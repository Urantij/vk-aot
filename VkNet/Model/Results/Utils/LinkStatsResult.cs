using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Данные о статистике.
/// </summary>
[Serializable]
public class LinkStatsResult
{
	/// <summary>
	/// Ключ
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Данные о статистике.
	/// </summary>
	[JsonPropertyName("stats")]
	public ReadOnlyCollection<LinkStat> Stats { get; set; }
}