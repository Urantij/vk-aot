using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Секция катеогории товара
/// </summary>
[Serializable]
public class MarketCategorySection
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Название секции
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}