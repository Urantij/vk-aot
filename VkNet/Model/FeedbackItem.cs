using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Feedback Item
/// </summary>
[Serializable]
public class FeedbackItem
{
	/// <summary>
	/// Идентификатор записи-ответа;
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Идентификатор стены, на которой размещена запись;
	/// </summary>
	[JsonPropertyName("to_id")]
	public long? ToId { get; set; }

	/// <summary>
	/// Идентификатор автора ответа;
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Текст ответа;
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Находится в записях со стен и содержит информацию о числе людей, которым
	/// понравилась данная запись
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	/// <summary>
	/// Содержит массив объектов, которые присоединены к текущей записи (фотографии,
	/// ссылки и т.п.)
	/// </summary>
	[JsonPropertyName("attachments")]
	// [JsonConverter(typeof(AttachmentJsonConverter))]
	public ReadOnlyCollection<Attachment> Attachments { get; set; }

	/// <summary>
	/// Находится в записях со стен, в которых имеется информация о местоположении
	/// </summary>
	[JsonPropertyName("geo")]
	public Geo Geo { get; set; }
}