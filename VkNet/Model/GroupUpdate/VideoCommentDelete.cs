using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление комментария к видео (<c>VideoCommentDelete</c>)
/// </summary>
[Serializable]
public class VideoCommentDelete : IGroupUpdate
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

	/// <summary>
	/// Идентификатор видео
	/// </summary>
	[JsonPropertyName("video_id")]
	public long? VideoId { get; set; }

	/// <summary>
	/// Идентификатор владельца видео
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор автора комментария
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который удалил комментарий
	/// </summary>
	[JsonPropertyName("deleter_id")]
	public long? DeleterId { get; set; }
}