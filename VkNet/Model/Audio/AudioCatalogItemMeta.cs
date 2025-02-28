using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о метаданных пользователя/сообщества.
/// </summary>
[Serializable]
public class AudioCatalogItemMeta
{
	/// <summary>
	/// Иконка.
	/// </summary>
	[JsonPropertyName("icon")]
	public string Icon { get; set; }

	/// <summary>
	/// Идентификатор владельца аудиозаписи.
	/// </summary>
	[JsonPropertyName("content_type")]
	public UserOrGroupType? ContentType { get; set; }
}