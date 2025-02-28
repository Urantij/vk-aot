using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса о получении беседы
/// </summary>
[Serializable]
public class ConversationResult
{
	/// <summary>
	/// Общее число результатов
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов бесед
	/// </summary>
	[JsonPropertyName("items")]
	public IEnumerable<Conversation> Items { get; set; }

	/// <summary>
	/// Профили
	/// </summary>
	[JsonPropertyName("profiles")]
	public IEnumerable<User> Profiles { get; set; }

	/// <summary>
	/// Группы
	/// </summary>
	[JsonPropertyName("groups")]
	public IEnumerable<Group> Groups { get; set; }
}