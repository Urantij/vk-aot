using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода Podcasts.search
/// </summary>
[Serializable]
public class PodcastsSearchParams
{
	/// <summary>
	/// Поисковый запрос.
	/// </summary>
	[JsonPropertyName("search_string")]
	public string SearchString { get; set; }

	/// <summary>
	/// Смещение, необходимое для выборки определённого подмножества результатов поиска.
	/// <remarks>
	/// По умолчанию — 0.
	/// </remarks>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; }

	/// <summary>
	/// Количество результатов поиска, которое необходимо вернуть.
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; }
}