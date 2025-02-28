using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Количество голосов
/// </summary>
[Serializable]
public class VotesAmount
{
	/// <summary>
	/// Количество голосов
	/// </summary>
	[JsonPropertyName("votes")]
	public string Votes { get; set; }

	/// <summary>
	/// Общая сумма голосов, переведённая в валюту
	/// </summary>
	[JsonPropertyName("amount")]
	public int Amount { get; set; }

	/// <summary>
	/// Описание общей суммы с наименованием валюты
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Название валюты
	/// </summary>
	[JsonPropertyName("currency")]
	public string Currency { get; set; }
}