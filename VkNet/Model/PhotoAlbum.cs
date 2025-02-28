using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Альбом для фотографий
/// </summary>
[Serializable]
public class PhotoAlbum
{
	/// <summary>
	/// Идентификатор созданного альбома
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор фотографии, которая является обложкой альбома
	/// </summary>
	[JsonPropertyName("thumb_id")]
	public long? ThumbId { get; set; }

	/// <summary>
	/// Идентификатор пользователя или сообщества, которому принадлежит альбом
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Название альбома
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание альбома
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Дата создания альбома
	/// </summary>
	[JsonPropertyName("created")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Created { get; set; }

	/// <summary>
	/// Дата обновления альбома
	/// </summary>
	[JsonPropertyName("updated")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Updated { get; set; }

	/// <summary>
	/// Количество фотографий в альбоме
	/// </summary>
	[JsonPropertyName("size")]
	public int? Size { get; set; }

	/// <summary>
	/// Настройки приватности для альбома в формате настроек приватности; (не приходит
	/// для системных альбомов)
	/// </summary>
	[JsonPropertyName("privacy_view")]
	public PrivacySettingsValue PrivacyView { get; set; }

	/// <summary>
	/// Настройки приватности для комментирования альбома
	/// </summary>
	[JsonPropertyName("privacy_comment")]
	public PrivacySettingsValue PrivacyComment { get; set; }

	/// <summary>
	/// Может ли текущий пользователь добавлять фотографии в альбом
	/// </summary>
	[JsonPropertyName("can_upload")]
	public bool? CanUpload { get; set; }

	/// <summary>
	/// Адрес на изображение с предпросмотром
	/// </summary>
	[JsonPropertyName("thumb_src")]
	public string ThumbSrc { get; set; }

	/// <summary>
	/// Размеры фотографий.
	/// </summary>
	[JsonPropertyName("sizes")]
	public IEnumerable<PhotoSize> Sizes { get; set; }

	/// <summary>
	/// Комментирование запрещено.
	/// </summary>
	[JsonPropertyName("comments_disabled")]
	public bool? CommentsDisabled { get; set; }

	/// <summary>
	/// Загружать могут только администраторы.
	/// </summary>
	[JsonPropertyName("upload_by_admins_only")]
	public bool UploadByAdminsOnly { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether this PhotoAlbum
	/// </summary>
	/// <remarks>
	/// Получено экспериментально.
	/// </remarks>
	[JsonPropertyName("thumb_is_last")]
	public bool ThumbIsLast { get; set; }

	[JsonPropertyName("album_id")]
	private long AlbumId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("aid")]
	private long Aid
	{
		get => Id;
		set => Id = value;
	}
}