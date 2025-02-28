using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление комментария к записи (<c>WallReplyDelete</c>)
/// </summary>
[Serializable]
public class WallReplyDelete : IGroupUpdate
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

	/// <summary>
	/// Идентификатор записи, к которой был оставлен комментарий
	/// </summary>
	[JsonPropertyName("post_id")]
	public long? PostId { get; set; }

	/// <summary>
	/// Идентификатор владельца стены
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