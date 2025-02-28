using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат получения журнала лидеров
/// </summary>
[Serializable]
public class LeaderboardResult
{
	/// <summary>
	/// Количество побед
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Список лидеров
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<LeaderboardItem> Items { get; set; }

	/// <summary>
	/// Список профилей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }
}