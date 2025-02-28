using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация об аудиоальбоме.
/// </summary>
[Serializable]
public class AudioAlbum
{
	/// <summary>
	/// Идентификатор альбома.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор владельца альбома (пользователь или сообщество).
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Название альбома.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Обложка альбома.
	/// </summary>
	[JsonPropertyName("thumb")]
	public AudioCover Thumb { get; set; }

	/// <summary>
	/// Ключ доступа.
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }
}