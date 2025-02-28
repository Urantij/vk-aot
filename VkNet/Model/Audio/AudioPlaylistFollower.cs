using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Подписчик плейлиста.
/// </summary>
[Serializable]
public class AudioPlaylistFollower
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
}