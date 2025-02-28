using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Цена.
/// </summary>
[Serializable]
public class Price
{
	/// <summary>
	/// Целочисленное значение цены, умноженное на 100.
	/// </summary>
	[JsonPropertyName("amount")]
	public long? Amount { get; set; }

	/// <summary>
	/// Валюта.
	/// </summary>
	[JsonPropertyName("currency")]
	public Currency Currency { get; set; }

	/// <summary>
	/// Старая цена товара в сотых долях единицы валюты.
	/// </summary>
	[JsonPropertyName("old_amount")]
	public string OldAmount { get; set; }

	/// <summary>
	/// Текстовое представлением старой цены.
	/// </summary>
	[JsonPropertyName("old_amount_text")]
	public string OldAmountText { get; set; }

	/// <summary>
	/// Строка с локализованной ценой и валютой.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}