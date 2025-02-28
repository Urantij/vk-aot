using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода wall.addComment
/// </summary>
[Serializable]
public class BoardCommentParams
{
	/// <summary>
	/// Идентификатор сообщества, в котором находится обсуждение. положительное число,
	/// обязательный параметр
	/// </summary>
	[JsonPropertyName("group_id")]
	public long GroupId { get; set; }

	/// <summary>
	/// Идентификатор обсуждения. положительное число,
	/// обязательный параметр
	/// </summary>
	[JsonPropertyName("topic_id")]
	public long TopicId { get; set; }

	/// <summary>
	/// Идентификатор комментария в обсуждении, обязательный параметр.
	/// </summary>
	[JsonPropertyName("comment_id")]
	public long CommentId { get; set; }
}