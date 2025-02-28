using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Категории для каталога сообществ
/// </summary>
[Serializable]
public class AdsCategories
{
	/// <summary>
	/// Название категории.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Gets or sets the subcategories.
	/// </summary>
	[JsonPropertyName("subcategories")]
	public IEnumerable<AdsCategories> Subcategories { get; set; }

	/// <summary>
	/// Идентификатор.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }
}