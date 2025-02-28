using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.getIntentUsers
/// </summary>
[Serializable]
public class GetIntentUsersResult
{
	/// <summary>
	/// Число результатов.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Массив идентификаторов пользователей в поле items.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<long> Items { get; set; }

	/// <summary>
	/// Массив объектов пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }
}