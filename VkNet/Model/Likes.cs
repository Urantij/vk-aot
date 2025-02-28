using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о лайках к записи.
/// См. описание http://vk.com/dev/post
/// </summary>
[Serializable]
public class Likes
{
	/// <summary>
	/// Число пользователей, которым понравилась запись.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Признак понравилась ли запись текущему пользователю.
	/// </summary>
	[JsonPropertyName("user_likes")]
	public bool UserLikes { get; set; }

	/// <summary>
	/// Признак может ли текущий пользователь поставить отметку "Мне нравится".
	/// </summary>
	[JsonPropertyName("can_like")]
	public bool CanLike { get; set; }

	/// <summary>
	/// Признак может ли текущий пользователь сделать репост записи (опубликовать у
	/// себя запись).
	/// </summary>
	[JsonPropertyName("can_publish")]
	public bool? CanPublish { get; set; }
}