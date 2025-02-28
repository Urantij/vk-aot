using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Статья
/// </summary>
[Serializable]
public class Article : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "article";

	/// <summary>
	/// Имя владельца
	/// </summary>
	[JsonPropertyName("owner_name")]
	public string OwnerName { get; set; }

	/// <summary>
	/// <c>Uri</c> к фотографии владельца
	/// </summary>
	[JsonPropertyName("owner_photo")]
	public Uri OwnerPhoto { get; set; }

	/// <summary>
	/// Состояние
	/// </summary>
	[JsonPropertyName("state")]
	public string State { get; set; }

	/// <summary>
	/// Можно ли пожаловаться на статью
	/// </summary>
	[JsonPropertyName("can_report")]
	public bool? CanReport { get; set; }

	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Подзаголовок
	/// </summary>
	[JsonPropertyName("subtitle")]
	public string Subtitle { get; set; }

	/// <summary>
	/// Количество показов
	/// </summary>
	[JsonPropertyName("views")]
	public int? Views { get; set; }

	/// <summary>
	/// Количество поделившихся
	/// </summary>
	[JsonPropertyName("shares")]
	public int? Shares { get; set; }

	/// <summary>
	/// Информация о том, есть ли статья в закладках у текущего пользователя
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool? IsFavorite { get; set; }

	/// <summary>
	/// Ссылка на статью
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Адрес превью статьи
	/// </summary>
	[JsonPropertyName("view_url")]
	public Uri ViewUrl { get; set; }

	/// <summary>
	/// Дата публикации статьи
	/// </summary>
	[JsonPropertyName("published_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? PublishedDate { get; set; }

	/// <summary>
	/// Обложка статьи
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }
}