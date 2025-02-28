using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Фотография.
/// </summary>
/// <remarks>
/// См. описание http://vk.com/dev/photo
/// </remarks>
[Serializable]
public class Photo : MediaAttachment, IGroupUpdate
{
	/// <inheritdoc />
	protected override string Alias => "photo";

	/// <summary>
	/// Идентификатор альбома, в котором находится фотография.
	/// </summary>
	[JsonPropertyName("album_id")]
	public long? AlbumId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, загрузившего фото (если фотография размещена в
	/// сообществе). Для фотографий, размещенных
	/// от имени сообщества.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Текст описания фотографии.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Дата добавления фотографии.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? CreateTime { get; set; }

	/// <summary>
	/// Размеры фотографий.
	/// </summary>
	[JsonPropertyName("sizes")]
	public ReadOnlyCollection<PhotoSize> Sizes { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 50x50px.
	/// </summary>
	[JsonPropertyName("photo_50")]
	public Uri Photo50 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 75x75px.
	/// </summary>
	[JsonPropertyName("photo_75")]
	public Uri Photo75 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 100x100px.
	/// </summary>
	[JsonPropertyName("photo_100")]
	public Uri Photo100 { get; set; }

	/// <summary>
	/// <c>Uri></c> фотографии с максимальным размером 130x130px.
	/// </summary>
	[JsonPropertyName("photo_130")]
	public Uri Photo130 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 200x200px.
	/// </summary>
	[JsonPropertyName("photo_200")]
	public Uri Photo200 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 604x604px.
	/// </summary>
	[JsonPropertyName("photo_604")]
	public Uri Photo604 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 807x807px.
	/// </summary>
	[JsonPropertyName("photo_807")]
	public Uri Photo807 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером 1280x1024px.
	/// </summary>
	[JsonPropertyName("photo_1280")]
	public Uri Photo1280 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером  2560x2048px.
	/// </summary>
	[JsonPropertyName("photo_2560")]
	public Uri Photo2560 { get; set; }

	/// <summary>
	/// Ширина оригинала фотографии в пикселах
	/// </summary>
	[JsonPropertyName("width")]
	public int? Width { get; set; }

	/// <summary>
	/// Высота оригинала фотографии в пикселах.
	/// </summary>
	[JsonPropertyName("height")]
	public int? Height { get; set; }

	/// <summary>
	/// Url фотографии.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	[JsonPropertyName("pid")]
	private long? Pid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("photo_id")]
	private long? PhotoId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("aid")]
	private long? Aid
	{
		get => AlbumId;
		set => AlbumId = value;
	}

	[JsonPropertyName("src")]
	private Uri Src
	{
		get => Photo130;
		set => Photo130 = value;
	}

	[JsonPropertyName("src_big")]
	private Uri SrcBig
	{
		get => Photo604;
		set => Photo604 = value;
	}

	[JsonPropertyName("src_xbig")]
	private Uri SrcXbig
	{
		get => Photo807;
		set => Photo807 = value;
	}

	[JsonPropertyName("src_xxbig")]
	private Uri SrcXXbig
	{
		get => Photo1280;
		set => Photo1280 = value;
	}

	[JsonPropertyName("src_xxxbig")]
	private Uri SrcXXXbig
	{
		get => Photo2560;
		set => Photo2560 = value;
	}

	[JsonPropertyName("created")]
	private DateTime? Created
	{
		get => CreateTime;
		set => CreateTime = value;
	}

	#region опциональные поля

	/// <summary>
	/// Идентификатор записи, у которой данная фотография является прикреплением???
	/// </summary>
	[JsonPropertyName("post_id")]
	public long? PostId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, сделавшего отметку
	/// </summary>
	[JsonPropertyName("placer_id")]
	public long? PlacerId { get; set; }

	/// <summary>
	/// Дата создания отметки
	/// </summary>
	[JsonPropertyName("tag_created")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? TagCreated { get; set; }

	/// <summary>
	/// Идентификатор отметки
	/// </summary>
	[JsonPropertyName("tag_id")]
	public long? TagId { get; set; }

	/// <summary>
	/// Лайки
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	/// <summary>
	/// Возможность комментирования фотографии
	/// </summary>
	[JsonPropertyName("can_comment")]
	public bool? CanComment { get; set; }

	/// <summary>
	/// Комментарии
	/// </summary>
	[JsonPropertyName("comments")]
	public Comments Comments { get; set; }

	/// <summary>
	/// Репосты
	/// </summary>
	[JsonPropertyName("reposts")]
	public Reposts Reposts { get; set; }

	/// <summary>
	/// Теги
	/// </summary>
	[JsonPropertyName("tags")]
	public Tags Tags { get; set; }

	/// <summary>
	/// Существование тегов
	/// </summary>
	[JsonPropertyName("has_tags")]
	public bool HasTags { get; set; }

	/// <summary>
	/// Источник изображения.
	/// </summary>
	[JsonPropertyName("photo_src")]
	public Uri PhotoSrc { get; set; }

	/// <summary>
	/// Хеш изображения.
	/// </summary>
	[JsonPropertyName("photo_hash")]
	public string PhotoHash { get; set; }

	/// <summary>
	/// Географическая широта отметки, заданная в градусах
	/// </summary>
	[JsonPropertyName("lat")]
	public double? Latitude { get; set; }

	/// <summary>
	/// Географическая долгота отметки, заданная в градусах
	/// </summary>
	[JsonPropertyName("long")]
	public double? Longitude { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с максимальным размером.
	/// </summary>
	[JsonPropertyName("big_photo_src")]
	public Uri BigPhotoSrc { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии с минимальным размером.
	/// </summary>
	[JsonPropertyName("src_small")]
	public Uri SmallPhotoSrc { get; set; }

	#endregion
}