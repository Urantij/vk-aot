using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Новости
/// </summary>
[Serializable]
public class TopicsFeed
{
	/// <summary>
	/// Количество.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Массив комментариев.
	/// </summary>
	[JsonPropertyName("items")] //TODO:
	public ReadOnlyCollection<CommentBoard> Items { get; set; }

	/// <summary>
	/// Информация о пользователях, которые находятся в списке комментариев.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Информация о группах, которые находятся в списке комментариев.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}