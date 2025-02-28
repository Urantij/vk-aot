using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Перевод денег
/// </summary>
[Serializable]
public class MoneyTransfer : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "money_transfer";

	/// <summary>
	/// Идентификатор отправителя
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Идентификатор получателя
	/// </summary>
	[JsonPropertyName("to_id")]
	public long ToId { get; set; }

	/// <summary>
	/// Состояние
	/// </summary>
	[JsonPropertyName("status")]
	public long Status { get; set; }

	/// <summary>
	/// Дата
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("amount")]
	public AmountObject Amount { get; set; }

	/// <summary>
	/// Комментарий
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }
}