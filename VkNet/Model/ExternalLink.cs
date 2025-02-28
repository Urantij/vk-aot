using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ссылки в группе
/// </summary>
[Serializable]
public class ExternalLink
{
	/// <summary>
	/// Идентификатор ссылки.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Адрес ссылки.
	/// </summary>
	[JsonPropertyName("url")]
	public string Uri { get; set; }

	/// <summary>
	/// Название страницы, на которую ведет ссылка.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Описание.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Фото 50px.
	/// </summary>
	[JsonPropertyName("photo_50")]
	public string Photo50 { get; set; }

	/// <summary>
	/// Фото 100px.
	/// </summary>
	[JsonPropertyName("photo_100")]
	public string Photo100 { get; set; }

	/// <summary>
	/// Возвращается 1, если можно редактировать название ссылки (для внешних ссылок)
	/// </summary>
	[JsonPropertyName("edit_title")]
	public bool? EditTitle { get; set; }

	/// <summary>
	/// Возвращается 1, если превью находится в процессе обработки.
	/// </summary>
	[JsonPropertyName("image_processing")]
	public bool? ImageProcessing { get; set; }

	[JsonPropertyName("desc")]
	private string Desc
	{
		get => Description;
		set => Description = value;
	}

	[JsonPropertyName("title")]
	private string Title
	{
		get => Name;
		set => Name = value;
	}
}