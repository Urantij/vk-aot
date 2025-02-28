using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Notes Restore Comment Params
/// </summary>
[Serializable]
public class NotesRestoreCommentParams
{
	/// <summary>
	/// идентификатор удаленного комментария
	/// </summary>
	[JsonPropertyName("comment_id")]
	public long? CommentId { get; set; }

	/// <summary>
	/// идентификатор владельца заметки.
	/// </summary>
	[JsonPropertyName("comment_id")]
	public long? OwnerId { get; set; }
}