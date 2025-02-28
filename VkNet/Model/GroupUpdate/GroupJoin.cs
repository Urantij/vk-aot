using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Добавление участника или заявки на вступление в сообщество
/// </summary>
[Serializable]
public class GroupJoin : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Указывает, как именно был добавлен участник.
	/// </summary>
	[JsonPropertyName("join_type")]
	[JsonConverter(typeof(JsonStringEnumConverter<GroupJoinType>))]
	public GroupJoinType? JoinType { get; set; }
}