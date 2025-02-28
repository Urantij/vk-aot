using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат поиска метода newsfeed.search
/// </summary>
[Serializable]
public class NewsSearchResult
{
	/// <summary>
	/// Список новостей
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<NewsSearchItem> Items { get; set; }

	/// <summary>
	/// Количество новостей
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Общее количество новостей
	/// </summary>
	[JsonPropertyName("total_count")]
	public long TotalCount { get; set; }

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
	/// Ключ для следующего поиска
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }
}