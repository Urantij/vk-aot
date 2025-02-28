using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Podcasts.getPopular
/// </summary>
[Serializable]
public class PodcastsGetPopularResult
{
	/// <summary>
	/// Владелец подкаста.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Название подкаста.
	/// </summary>
	[JsonPropertyName("owner_title")]
	public string OwnerTitle { get; set; }

	/// <summary>
	/// Короткое имя группы подкаста.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }
}