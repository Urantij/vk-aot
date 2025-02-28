using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Секция
/// </summary>
[Serializable]
public class PrivacySettingsSection
{
	/// <summary>
	/// Наименование секции
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Заголовок секции
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }
}