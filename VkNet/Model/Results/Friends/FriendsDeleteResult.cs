using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса Friends.Delete
/// </summary>
[Serializable]
public class FriendsDeleteResult
{
	/// <summary>
	/// Удалось успешно удалить друга
	/// </summary>
	[JsonPropertyName("success")]
	public bool? Success { get; set; }

	/// <summary>
	/// Был удален друг
	/// </summary>
	[JsonPropertyName("friend_deleted")]
	public bool? FriendDeleted { get; set; }

	/// <summary>
	/// Отменена исходящая заявка
	/// </summary>
	[JsonPropertyName("out_request_deleted")]
	public bool? OutRequestDeleted { get; set; }

	/// <summary>
	/// Отклонена входящая заявка
	/// </summary>
	[JsonPropertyName("in_request_deleted")]
	public bool? InRequestDeleted { get; set; }

	/// <summary>
	/// Отклонена рекомендация друга
	/// </summary>
	[JsonPropertyName("suggestion_deleted")]
	public bool? SuggestionDeleted { get; set; }
}