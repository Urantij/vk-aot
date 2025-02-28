using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление участника или заявки на вступление в сообщество
/// </summary>
[Serializable]
public class DonutNew : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Цена в рублях
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; set; }

	/// <summary>
	/// Цена без комиссии (в рублях)
	/// </summary>
	[JsonPropertyName("amount_without_fee")]
	public decimal? AmountWithoutFee { get; set; }
}