using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление комментария к товару (<c>MarketCommentDelete</c>)
/// </summary>
[Serializable]
public class MarketCommentDelete : IGroupUpdate
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

	/// <summary>
	/// Идентификатор товара
	/// </summary>
	[JsonPropertyName("item_id")]
	public ulong? ItemId { get; set; }

	/// <summary>
	/// Идентификатор владельца товара
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