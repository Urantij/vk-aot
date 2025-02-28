using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ на запрос метода groups.getCatalogInfo
/// </summary>
[Serializable]
public class GroupsCatalogInfo
{
	/// <summary>
	/// Список категорий.
	/// </summary>
	[JsonPropertyName("categories")]
	public IEnumerable<CategoryGroup> Categories { get; set; }

	/// <summary>
	/// Признак доступности каталога для пользователя.
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool Enabled { get; set; }
}