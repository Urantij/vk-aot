using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Notes Create Comment Params
/// </summary>
[Serializable]
public class NotesCreateCommentParams
{
	/// <summary>
	/// Идентификатор заметки.
	/// </summary>
	[JsonPropertyName("note_id")]
	public long? NoteId { get; set; }

	/// <summary>
	/// Идентификатор владельца заметки.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, ответом на комментарий которого является
	///добавляемый комментарий (не передаётся, если
	///комментарий не является ответом).
	/// </summary>
	[JsonPropertyName("reply_to")]
	public long? ReplyTo { get; set; }

	/// <summary>
	/// Текст комментария.
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }
}