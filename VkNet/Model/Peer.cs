using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о собеседнике.
/// </summary>
[Serializable]
public class Peer
{
	/// <summary>
	/// Идентификатор назначения.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип.
	/// </summary>
	[JsonPropertyName("type")]
	public ConversationPeerType? Type { get; set; }

	/// <summary>
	/// Локальный идентификатор назначения.
	/// </summary>
	[JsonPropertyName("local_id")]
	public long LocalId { get; set; }
}