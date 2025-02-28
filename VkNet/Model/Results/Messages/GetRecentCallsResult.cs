using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса messages.GetRecentCalls
/// </summary>
[Serializable]
public class GetRecentCallsResult
{
	/// <summary>
	/// Число результатов.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Сообщения
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Message> Messages { get; set; }

	/// <summary>
	/// Профили пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Массив объектов сообществ.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}