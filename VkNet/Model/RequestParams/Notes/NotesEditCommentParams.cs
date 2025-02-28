using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Notes Edit Comment Params
/// </summary>
[Serializable]
public class NotesEditCommentParams
{
	/// <summary>
	/// Идентификатор комментария.
	///положительное число, (обязательный параметр)
	/// </summary>
	[JsonPropertyName("comment_id")]
	public long? CommentId { get; set; }

	/// <summary>
	///Идентификатор владельца заметки.
	///положительное число, по умолчанию идентификатор текущего пользователя
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Новый текст комментария.
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }
}