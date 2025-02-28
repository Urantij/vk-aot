using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление участника или заявки на вступление в сообщество
/// </summary>
[Serializable]
public class DonutWithdraw : IGroupUpdate
{
	private string _reason;

	/// <summary>
	/// Произошла ли ошибка
	/// </summary>
	[JsonPropertyName("error")]
	public bool Error { get; set; }

		/// <summary>
	/// Cумма  в рублях
	/// </summary>
	[JsonPropertyName("amount")]
	public float? Amount { get; set; }

	/// <summary>
	/// Cумма  без комиссии (в рублях)
	/// </summary>
	[JsonPropertyName("amount_without_fee")]
	public float? AmountWithoutFee { get; set; }

	/// <summary>
	/// Причина ошибки
	/// </summary>
	[JsonPropertyName("reason")]
	public string Reason
	{
		get => _reason;

		set {
			_reason = value;
			Error = !string.IsNullOrEmpty(_reason);
		}
	}
}