using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о подкасте
/// </summary>
[Serializable]
public class PodcastInfo
{
	/// <summary>
	/// Обложка.
	/// </summary>
	[JsonPropertyName("cover")]
	public Cover Cover { get; set; }

	/// <summary>
	/// Количество прослушиваний.
	/// </summary>
	[JsonPropertyName("plays")]
	public long Plays { get; set; }

	/// <summary>
	/// Важный.
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool IsFavorite { get; set; }

	/// <summary>
	/// Позиция.
	/// </summary>
	[JsonPropertyName("position")]
	public long? Position { get; set; }

	/// <summary>
	/// Описание.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }
}