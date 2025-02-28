using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Комментарий в обсуждении
/// </summary>
[Serializable]
public class CommentBoard
{
	/// <summary>
	/// Идентификатор комментария.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Дата создания (в формате Unixtime).
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Текст комментария.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Медиавложения комментария (фотографии, ссылки и т.п.).
	/// </summary>
	[JsonPropertyName("attachments")]
	// [JsonConverter(converterType: typeof(AttachmentJsonConverter))]
	public ReadOnlyCollection<Attachment> Attachments { get; set; }

	/// <summary>
	/// Информация об отметках «Мне нравится» текущего комментария (если был задан
	/// параметр need_likes)
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }
}