using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Количество
/// </summary>
[Serializable]
public class AmountObject
{
	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("amount")]
	public long Amount { get; set; }

	/// <summary>
	/// Валюта
	/// </summary>
	[JsonPropertyName("currency")]
	public Currency Currency { get; set; }

	/// <summary>
	/// Текст
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}