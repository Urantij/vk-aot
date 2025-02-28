using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.GetConversationsResult
/// </summary>
[Serializable]
public class GetConversationsResult
{
	/// <summary>
	/// Число результатов.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Беседы
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<ConversationAndLastMessage> Items { get; set; }

	/// <summary>
	/// Число непрочитанных бесед.
	/// </summary>
	[JsonPropertyName("unread_count")]
	public long UnreadCount { get; set; }

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