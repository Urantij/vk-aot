using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление комментария в обсуждении (<c>BoardPostDelete</c>)
/// </summary>
[Serializable]
public class BoardPostDelete : IGroupUpdate
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

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