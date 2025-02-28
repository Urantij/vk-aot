using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.getByConversationMessageId
/// </summary>
[Serializable]
public class GetByConversationMessageIdResult
{
	/// <summary>
	/// Число результатов
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов, описывающих сообщения
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Message> Items { get; set; }

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