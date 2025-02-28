using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Subscriptions
/// </summary>
[Serializable]
public class SubscriptionsInfo
{
	/// <summary>
	/// Массив объектов подписок.
	/// </summary>
	[JsonPropertyName("subscritions")]
	public IEnumerable<Subscription> Subscriptions { get; set; }

	/// <summary>
	/// Количество подписок.
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public IEnumerable<User> Profiles { get; set; }

	/// <summary>
	/// Массив объектов сообществ.
	/// </summary>
	[JsonPropertyName("groups")]
	public IEnumerable<Group> Groups { get; set; }
}