using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление пользователя из чёрного списка
/// </summary>
[Serializable]
public class UserUnblock : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор администратора, который убрал пользователя из чёрного списка
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long? AdminId { get; set; }

	/// <summary>
	/// Была ли разблокировка по окончанию блокировки
	/// </summary>
	[JsonPropertyName("by_end_date")]
	public bool? ByEndDate { get; set; }
}