using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ на запрос wall.getComment
/// </summary>
[Serializable]
public class WallGetCommentResult
{
	/// <summary>
	/// Объект комментария
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<WallReplyGroupUpdate> Comment { get; set; }

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
}