using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление/редактирование/восстановление комментария в обсуждении(<c>BoardPostNew</c>, <c>BoardPostEdit</c>, <c>BoardPostRestore</c>)
/// (<c>CommentBoard</c> с дополнительными полями)
/// </summary>
[Serializable]
public class BoardPost : CommentBoard, IGroupUpdate
{
	/// <summary>
	/// Идентификатор обсуждения
	/// </summary>
	[JsonPropertyName("topic_id")]
	public ulong? TopicId { get; set; }

	/// <summary>
	/// Идентификатор владельца обсуждения
	/// </summary>
	[JsonPropertyName("topic_owner_id")]
	public long? TopicOwnerId { get; set; }
}