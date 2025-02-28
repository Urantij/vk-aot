using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Альбом с фотографиями пользователя.
/// См. описание http://vk.com/dev/attachments_w
/// </summary>
[Serializable]
public class Album : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "album";

	/// <summary>
	/// Обложка альбома.
	/// </summary>
	[JsonPropertyName("thumb")]
	public Photo Thumb { get; set; }

	/// <summary>
	/// Название альбома.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание альбома.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Дата и время создания альбома.
	/// </summary>
	[JsonPropertyName("created")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Дата и время последнего обновления альбома.
	/// </summary>
	[JsonPropertyName("updated")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? UpdateTime { get; set; }

	/// <summary>
	/// Количество фотографий в альбоме.
	/// </summary>
	[JsonPropertyName("size")]
	public int Size { get; set; }

	[JsonPropertyName("aid")]
	private long? Aid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("album_id")]
	private long? AlbumId
	{
		get => Id;
		set => Id = value;
	}
}