using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий элемент видеокаталога
/// </summary>
[Serializable]
public class VideoCatalogItem
{
	/// <summary>
	/// идентификатор элемента.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// идентификатор владельца элемента.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// название элемента.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// тип элемента.
	/// </summary>
	[JsonPropertyName("type")]
	public VideoCatalogItemType? Type { get; set; }

	/// <summary>
	/// текст описания.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// длительность ролика в секундах.
	/// </summary>
	[JsonPropertyName("duration")]
	public long? Duration { get; set; }

	/// <summary>
	/// URL изображения-обложки ролика шириной 130px.
	/// </summary>
	[JsonPropertyName("photo_130")]
	public Uri Photo130 { get; set; }

	/// <summary>
	/// URL изображения-обложки ролика шириной 320px.
	/// </summary>
	[JsonPropertyName("photo_320")]
	public Uri Photo320 { get; set; }

	/// <summary>
	/// URL изображения-обложки ролика шириной 640px (если размер есть).
	/// </summary>
	[JsonPropertyName("photo_640")]
	public Uri Photo640 { get; set; }

	/// <summary>
	/// URL изображения-обложки ролика шириной 800px (если размер есть).
	/// </summary>
	[JsonPropertyName("photo_800")]
	public Uri Photo800 { get; set; }

	/// <summary>
	/// дата создания видеозаписи в формате Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// дата добавления видеозаписи пользователем или группой в формате Unixtime.
	/// </summary>
	[JsonPropertyName("adding_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? AddingDate { get; set; }

	/// <summary>
	/// количество просмотров видеозаписи.
	/// </summary>
	[JsonPropertyName("views")]
	public long? Views { get; set; }

	/// <summary>
	/// количество комментариев к видеозаписи.
	/// </summary>
	[JsonPropertyName("comments")]
	public long? Comments { get; set; }

	/// <summary>
	/// наличие возможности добавить ролик в свой список.
	/// </summary>
	[JsonPropertyName("can_add")]
	public bool? CanAdd { get; set; }

	/// <summary>
	/// наличие возможности редактировать видео.
	/// </summary>
	[JsonPropertyName("can_edit")]
	public bool? CanEdit { get; set; }

	/// <summary>
	/// приватность ролика (0 — нет, 1 — есть).
	/// </summary>
	[JsonPropertyName("is_private")]
	public bool? IsPrivate { get; set; }

	/// <summary>
	/// число видеозаписей в альбоме.
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// URL изображения-обложки альбома с размером 272x150px.
	/// </summary>
	[JsonPropertyName("photo_160")]
	public Uri Photo160 { get; set; }

	/// <summary>
	/// время последнего обновления альбома в формате unixtime.
	/// </summary>
	[JsonPropertyName("updated_time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? UpdatedTime { get; set; }
}