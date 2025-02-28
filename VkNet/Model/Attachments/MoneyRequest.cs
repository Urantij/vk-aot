using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Выставление счета
/// </summary>
[Serializable]
public class MoneyRequest : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "money_request";

	/// <summary>
	/// Идентификатор инициатора
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Идентификатор получателя
	/// </summary>
	[JsonPropertyName("to_id")]
	public long ToId { get; set; }

	/// <summary>
	/// Статус обработанности
	/// </summary>
	[JsonPropertyName("processed")]
	public bool Processed { get; set; }

	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("amount")]
	public AmountObject Amount { get; set; }

	/// <summary>
	/// Ссылка на выставленный счет
	/// </summary>
	[JsonPropertyName("init_url")]
	public Uri InitUrl { get; set; }
}