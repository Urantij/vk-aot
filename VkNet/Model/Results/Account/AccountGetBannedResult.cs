using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат вызова метода <see cref="VkNet.Abstractions.IAccountCategory.GetBanned"/>
/// </summary>
[Serializable]
public class AccountGetBannedResult
{
	/// <summary>
	/// Общее количество записей на стене.
	/// </summary>.
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Посты.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<long> Items { get; set; }

	/// <summary>
	/// Профили.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Группы.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}