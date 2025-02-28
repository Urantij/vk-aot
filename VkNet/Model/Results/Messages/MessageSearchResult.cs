using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.search
/// </summary>
[Serializable]
public class MessageSearchResult
{
	/// <summary>
	/// Количество найденных сообщений
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Личные сообщения
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Message> Items { get; set; }

	/// <summary>
	/// Профили пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Сообщества
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }

	/// <summary>
	/// Беседы
	/// </summary>
	[JsonPropertyName("conversations")]
	public IEnumerable<Conversation> Conversations { get; set; }
}