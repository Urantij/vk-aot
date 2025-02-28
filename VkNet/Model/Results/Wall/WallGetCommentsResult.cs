using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ на запрос wall.getComments
/// </summary>
[Serializable]
public class WallGetCommentsResult
{
	/// <summary>
	/// Количество комментариев
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов комментариев
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Comment> Items { get; set; }

	/// <summary>
	/// Массив пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("current_level_count")]
	public long? CurrentLevelCount { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("can_post")]
	public bool? CanPost { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("show_reply_button")]
	public bool? ShowReplyButton { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("groups_can_post")]
	public bool? GroupsCanPost { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("user_likes")]
	public bool? UserLikes { get; set; }

	/// <summary>
	/// Массив групп
	/// </summary>
	[JsonPropertyName("can_like")]
	public bool? CanLike { get; set; }
}