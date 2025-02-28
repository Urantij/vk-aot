using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о вложенной ветке комментариев
/// </summary>
[Serializable]
public class CommentThread
{
	/// <summary>
	/// Количество комментариев в ветке
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// Массив объектов комментариев к записи
	/// </summary>
	/// <remarks>
	/// Только для метода wall.getComments
	/// </remarks>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Comment> Items { get; set; }

	/// <summary>
	/// Может ли текущий пользователь оставлять комментарии в этой ветке
	/// </summary>
	[JsonPropertyName("can_post")]
	public bool? CanPost { get; set; }

	/// <summary>
	/// Нужно ли отображать кнопку «ответить» в ветке
	/// </summary>
	[JsonPropertyName("show_reply_button")]
	public bool? ShowReplyButton { get; set; }

	/// <summary>
	/// Могут ли сообщества оставлять комментарии в ветке.
	/// </summary>
	[JsonPropertyName("groups_can_post")]
	public bool? GroupsCanPost { get; set; }
}