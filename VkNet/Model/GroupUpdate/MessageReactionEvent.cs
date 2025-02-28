using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary> Объект, который содержит событие реакции на сообщение. </summary>
[Serializable]
public class MessageReactionEvent : IGroupUpdate
{
	/// <summary>Идентификатор события реакции.</summary>
	[JsonPropertyName("reacted_id")]
	public long ReactedId { get; set; }

	/// <summary>Идентификатор назначения.</summary>
	[JsonPropertyName("peer_id")]
	public long PeerId { get; set; }

	/// <summary>Идентификатор сообщения в беседе.</summary>
	[JsonPropertyName("cmid")]
	public ulong Cmid { get; set; }

	/// <summary>Идентификатор реакции.</summary>
	[JsonPropertyName("reaction_id")]
	public ulong? ReactionId { get; set; }
}