using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
///  Комментарий к заметке
/// </summary>
[Serializable]
public class CommentNote
{
	/// <summary>
	/// идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// идентификатор автора комментария
	/// </summary>
	[JsonPropertyName("uid")]
	public long? UserId { get; set; }

	/// <summary>
	/// идентификатор заметки
	/// </summary>
	[JsonPropertyName("nid")]
	public long? NoteId { get; set; }

	/// <summary>
	/// идентификатор владельца заметки
	/// </summary>
	[JsonPropertyName("oid")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Дата добавления комментария в формате unixtime
	/// </summary>
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime? Date { get; set; }

	/// <summary>
	/// текст комментария
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }

	/// <summary>
	/// идентификатор пользователя, в ответ на комментарий которого
	/// был оставлен текущий комментарий (если доступно).
	/// </summary>
	[JsonPropertyName("reply_to")]
	public long? ReplyTo { get; set; }
}