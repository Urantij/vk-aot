using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Список параметров для метода messages.changeConversationMemberRestrictions
/// </summary>
[Serializable]
public class MessagesChangeConversationMemberRestrictionsParams
{
	/// <summary>
	/// Идентификатор назначения.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long PeerId { get; set; }

	/// <summary>
	/// Идентификаторы пользователей.
	/// </summary>
	[JsonPropertyName("member_ids")]
	public IEnumerable<long> MemberIds { get; set; }

	/// <summary>
	/// Время в секундах. Если нужно замутить навсегда, то указывать не нужно.
	/// </summary>
	[JsonPropertyName("for")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? For { get; set; }

	/// <summary>
	/// Разрешенные действия.
	/// </summary>
	[JsonPropertyName("action")]
	public ConversationMemberRestrictionsActionType Action { get; set; }
}