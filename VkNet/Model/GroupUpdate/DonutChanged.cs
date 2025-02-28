using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление участника или заявки на вступление в сообщество
/// </summary>
[Serializable]
public class DonutChanged : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Старая цена в рублях
	/// </summary>
	[JsonPropertyName("amount_old")]
	public int? AmountOld { get; set; }

	/// <summary>
	/// Новая цена в рублях
	/// </summary>
	[JsonPropertyName("amount_new")]
	public int? AmountNew { get; set; }

	/// <summary>
	/// Сумма доплаты в рублях
	/// </summary>
	[JsonPropertyName("amount_diff")]
	public float? AmountDiff { get; set; }

	/// <summary>
	/// Cумма доплаты без комиссии (в рублях)
	/// </summary>
	[JsonPropertyName("amount_diff_without_fee")]
	public float? AmountDiffWithoutFee { get; set; }
}