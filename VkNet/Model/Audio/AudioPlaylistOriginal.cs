using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Неизвестно.
/// </summary>
[Serializable]
public class AudioPlaylistOriginal
{
	/// <summary>
	/// Идентификатор владельца.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Идентификатор плейлиста.
	/// </summary>
	[JsonPropertyName("playlist_id")]
	public long PlaylistId { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }
}