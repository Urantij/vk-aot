using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Настройка
/// </summary>
[Serializable]
public class PrivacySettingSetting
{
	/// <summary>
	/// Ключ
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Текущее значение
	/// </summary>
	[JsonPropertyName("value")]
	public PrivacySettingsValue Value { get; set; }

	/// <summary>
	/// Секция
	/// </summary>
	[JsonPropertyName("section")]
	public string Section { get; set; }

	/// <summary>
	/// Тип
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Поддерживаемые категории
	/// </summary>
	[JsonPropertyName("supported_categories")]
	public string[] SupportedCategories { get; set; }
}