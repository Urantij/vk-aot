using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода ShortVideo.Create
/// </summary>
[Serializable]
public class ShortVideoUploadServer
{
	/// <summary>
	/// Адрес для загрузки Клипа
	/// </summary>
	[JsonPropertyName("upload_url")]
	public Uri UploadUrl { get; set; }

	/// <summary>
	/// Идентификатор владельца Клипа
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор Клипа
	/// </summary>
	[JsonPropertyName("video_id")]
	public long? VideoId { get; set; }
}