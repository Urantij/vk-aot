using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Поддерживаемые категории
/// </summary>
[Serializable]
public class SupportedCategories
{
	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Текущее значение
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }
}