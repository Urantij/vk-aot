using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Приватные настройки
/// </summary>
[Serializable]
public class PrivacySettings
{
	/// <summary>
	/// Настройки
	/// </summary>
	[JsonPropertyName("settings")]
	public PrivacySettingSetting[] Settings { get; set; }

	/// <summary>
	/// Секции
	/// </summary>
	[JsonPropertyName("sections")]
	public PrivacySettingsSection[] Sections { get; set; }

	/// <summary>
	/// Поддерживаемые категории
	/// </summary>
	[JsonPropertyName("supported_categories")]
	public SupportedCategories[] SupportedCategories { get; set; }
}