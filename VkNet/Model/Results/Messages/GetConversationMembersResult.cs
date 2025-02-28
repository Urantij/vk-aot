using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.GetConversationMembersResult
/// </summary>
[Serializable]
public class GetConversationMembersResult
{
	/// <summary>
	/// Число участников беседы.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Участники беседы.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<ConversationMember> Items { get; set; }

	/// <summary>
	/// Массив объектов пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Массив объектов сообществ.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}