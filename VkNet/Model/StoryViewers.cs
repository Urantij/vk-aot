using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ метода Stories.GetViewers
/// </summary>
[Serializable]
public class StoryViewers
{
	/// <summary>
	/// Поставил ли пользователь лайк
	/// </summary>
	[JsonPropertyName("is_liked")]
	public bool IsLiked { get; set; }

	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }
}