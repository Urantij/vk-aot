using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения запроса получения приложений
/// </summary>
[Serializable]
public class AppGetObject
{
	/// <summary>
	/// Общее количество записей на стене.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong TotalCount { get; set; }

	/// <summary>
	/// Приложения.
	/// </summary>
	[JsonPropertyName("items")]
	public IEnumerable<App> Apps { get; set; }

	/// <summary>
	/// Друзья.
	/// </summary>
	[JsonPropertyName("profiles")]
	public IEnumerable<User> Friends { get; set; }
}