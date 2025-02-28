using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Subscription
/// </summary>
[Serializable]
public class Subscription
{
	/// <summary>
	/// Идентификатор сообщества, доном которого является пользователь.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Дата следующего платежа в формате "unixtime".
	/// </summary>
	[JsonPropertyName("next_payment_date")]
	public long NextPaymentDate { get; set; }

	/// <summary>
	/// Стоимость подписки.
	/// </summary>
	[JsonPropertyName("amount")]
	public long Amount { get; set; }

	/// <summary>
	/// Статус подписки.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }
}