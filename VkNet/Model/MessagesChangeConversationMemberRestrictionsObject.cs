using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения запроса установки ограничений участнику чата
/// </summary>
[Serializable]
public class MessagesChangeConversationMemberRestrictionsObject
{
	/// <summary>
	/// Список идентификаторов, к которым не удалось применить ограничения
	/// </summary>
	[JsonPropertyName("failed_member_ids")]
	public ReadOnlyCollection<long> FailedMemberIds { get; set; }
}