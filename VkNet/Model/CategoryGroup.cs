using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Категории для каталога сообществ
/// </summary>
[Serializable]
public class CategoryGroup
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
	public IEnumerable<CategoryGroup> Subcategories { get; set; }

	/// <summary>
	/// Количество сообществ в категории.
	/// </summary>
	[JsonPropertyName("page_count")]
	public long? PageCount { get; set; }

	/// <summary>
	/// Массив объектов сообществ для предпросмотра.
	/// </summary>
	[JsonPropertyName("page_previews")]
	public IEnumerable<Group> PagePreviews { get; set; }

	/// <summary>
	/// Идентификатор.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }
}