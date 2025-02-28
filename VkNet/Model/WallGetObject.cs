using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения запроса получения записей со стены
/// </summary>
[Serializable]
public class WallGetObject
{
	/// <summary>
	/// Общее количество записей на стене.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong TotalCount { get; set; }

		/// <summary>
	/// Посты.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Post> WallPosts { get; set; }

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