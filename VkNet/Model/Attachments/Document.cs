using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о документе.
/// См. описание http://vk.com/dev/doc
/// </summary>
[Serializable]
public class Document : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "doc";

	/// <summary>
	/// Название документа.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Размер документа в байтах.
	/// </summary>
	[JsonPropertyName("size")]
	public long? Size { get; set; }

	/// <summary>
	/// Расширение документа.
	/// </summary>
	[JsonPropertyName("ext")]
	public string Ext { get; set; }

	/// <summary>
	/// Адрес документа, по которому его можно загрузить.
	/// </summary>
	[JsonPropertyName("url")]
	public string Uri { get; set; }

	/// <summary>
	/// Дата добавления в формате unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Тип документа
	/// </summary>
	[JsonPropertyName("type")]
	public DocumentTypeEnum Type { get; set; }

	/// <summary>
	/// Информация для предварительного просмотра документа
	/// </summary>
	[JsonPropertyName("preview")]
	public DocumentPreview Preview { get; set; }

	/// <summary>
	/// Адрес изображения с размером 100x75px (если файл графический).
	/// </summary>
	[JsonPropertyName("photo_100")]
	public string Photo100 { get; set; }

	/// <summary>
	/// Адрес изображения с размером 130x100px (если файл графический).
	/// </summary>
	[JsonPropertyName("photo_130")]
	public string Photo130 { get; set; }

	[JsonPropertyName("did")]
	private long? Did
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("doc_id")]
	private long? DocId
	{
		get => Id;
		set => Id = value;
	}
}