using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Адрес сервера для загрузки фотографий
/// </summary>
[Serializable]
public class UploadServerInfo
{
	/// <summary>
	/// Адрес для загрузки фотографий
	/// </summary>
	[JsonPropertyName("upload_url")]
	public string UploadUrl { get; set; }

	/// <summary>
	/// Идентификатор альбома, в который будет загружена фотография
	/// </summary>
	[JsonPropertyName("album_id")]
	public long? AlbumId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, от чьего имени будет загружено фото
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	[JsonPropertyName("aid")]
	private long? Aid
	{
		get => AlbumId;
		set => AlbumId = value;
	}

	[JsonPropertyName("message_id")]
	private long? MessageId
	{
		get => UserId;
		set => UserId = value;
	}

	[JsonPropertyName("mid")]
	private long? Mid
	{
		get => UserId;
		set => UserId = value;
	}
}