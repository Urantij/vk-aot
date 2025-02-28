using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Видеоальбом.
/// </summary>
/// <remarks>
/// Страница документации ВКонтакте http://vk.com/dev/video.getAlbums
/// </remarks>
[Serializable]
public class VideoAlbum
{
	/// <summary>
	/// Идентификатор альбома.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор владельца альбома.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Название альбома.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Количество видеозаписей в альбоме.
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// URL изображения предпросмотра альбома шириной в 160 пикселов.
	/// </summary>
	[Obsolete("Это свойство устарело в версии api 5.101. Используйте свойство IEnumerable<VideoImage> Image")]
	[JsonPropertyName("photo_160")]
	public string Photo160 { get; set; }

	/// <summary>
	/// URL изображения предпросмотра альбома шириной в 320 пикселов.
	/// </summary>
	[Obsolete("Это свойство устарело в версии api 5.101. Используйте свойство IEnumerable<VideoImage> Image")]
	[JsonPropertyName("photo_320")]
	public string Photo320 { get; set; }

	/// <summary>
	/// Список изображений обложки альбома.
	/// </summary>
	[JsonPropertyName("image")]
	public IEnumerable<VideoImage> Image { get; set; }

	/// <summary>
	/// время последнего обновления в формате unixtime
	/// </summary>
	[JsonPropertyName("updated_time")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? UpdatedTime { get; set; }
}