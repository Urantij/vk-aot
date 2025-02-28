using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Добавление пользователя в чёрный список
/// </summary>
[Serializable]
public class UserBlock : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор администратора, который внёс пользователя в чёрный список
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long? AdminId { get; set; }

	/// <summary>
	/// Дата разблокировки
	/// </summary>
	[JsonPropertyName("unblock_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? UnblockDate { get; set; }

	/// <summary>
	/// Причины блокировки пользователя
	/// </summary>
	[JsonPropertyName("reason")]
	public BanReason? Reason { get; set; }

	/// <summary>
	/// Комментарий администратора к блокировке
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }
}