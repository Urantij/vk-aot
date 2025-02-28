using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Категория товара.
/// </summary>
[Serializable]
public class MarketCategory
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Название категории
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Секция
	/// </summary>
	[JsonPropertyName("section")]
	public MarketCategorySection Section { get; set; }
}