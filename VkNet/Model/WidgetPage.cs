using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект-страница для виджета
/// </summary>
[Serializable]
public class WidgetPage
{
	/// <summary>
	/// Идентификатор страницы в системе;
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Заголовок страницы (берется из мета-тегов на странице или задается параметром
	/// pageTitle при инициализации)
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Краткое описание страницы (берется из мета-тегов на странице или задается
	/// параметром pageDescription при
	/// инициализации);
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Абсолютный адрес страницы;
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Объект, содержащий поле count — количество отметок «Мне нравится» к странице.
	/// </summary>
	[JsonPropertyName("likes")]
	public ObjectCount Likes { get; set; }

	/// <summary>
	/// Объект, содержащий поле count — количество комментариев к странице внутри
	/// виджета.
	/// </summary>
	[JsonPropertyName("comments")]
	public ObjectCount Comments { get; set; }

	/// <summary>
	/// Дата первого обращения к виджетам на странице
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Объект, содержащий фотографию-миниатюру страницы (берется из мета-тегов на
	/// странице или задается параметром
	/// pageImage при инициализации)
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Внутренний идентификатор страницы в приложении/на сайте (в случае, если при
	/// инициализации виджетов использовался
	/// параметр page_id);
	/// </summary>
	[JsonPropertyName("pageId")]
	public long PageId { get; set; }
}