using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Podcasts.search
/// </summary>
[Serializable]
public class PodcastsSearchResult
{
	/// <summary>
	/// Количество найденных подкастов
	/// </summary>
	[JsonPropertyName("results_total")]
	public ulong ResultsTotal { get; set; }
	/// <summary>
	/// Информация о подкасте, выданная поиском
	/// </summary>
	[JsonPropertyName("podcasts")]
	public ReadOnlyCollection<PodcastSearchInfo> Podcasts { get; set; }
}