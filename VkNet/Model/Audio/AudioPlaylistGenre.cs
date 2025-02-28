using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Жанр плейлиста.
/// </summary>
[Serializable]
public class AudioPlaylistGenre
{
	/// <summary>
	/// Идентификатор жанра.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название жанра.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}