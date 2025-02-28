using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Notes Delete Comment Params
/// </summary>
[Serializable]
public class NotesDeleteCommentParams
{
	/// <summary>
	/// Идентификатор комментария.
	/// </summary>
	[JsonPropertyName("comment_id")]
	public long? CommentId { get; set; }

	/// <summary>
	/// Идентификатор владельца заметки.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }
}