using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса messages.searchConversations
/// </summary>
[Serializable]
public class SearchConversationsResult
{
	/// <summary>
	/// Число результатов
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов диалогов
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Conversation> Items { get; set; }

	/// <summary>
	/// Массив объектов пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }
}