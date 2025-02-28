using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о пользователе/сообществе.
/// </summary>
[Serializable]
public class AudioCatalogItem
{
	/// <summary>
	/// Имя исполнителя.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("subtitle")]
	public string Subtitle { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("image")]
	public ReadOnlyCollection<AudioCatalogItemImage> Image { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("meta")]
	public AudioCatalogItemMeta Meta { get; set; }
}