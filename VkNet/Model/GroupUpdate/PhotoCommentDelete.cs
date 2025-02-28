using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление комментария к фотографии (<c>PhotoCommentDelete</c>)
/// </summary>
[Serializable]
public class PhotoCommentDelete : IGroupUpdate
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

	/// <summary>
	/// Идентификатор фотографии
	/// </summary>
	[JsonPropertyName("photo_id")]
	public long? PhotoId { get; set; }

	/// <summary>
	/// Идентификатор владельца фотографии
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