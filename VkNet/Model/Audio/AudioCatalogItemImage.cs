using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о фото пользователя/сообщества
/// </summary>
[Serializable]
public class AudioCatalogItemImage
{
	/// <summary>
	/// Ширина.
	/// </summary>
	[JsonPropertyName("width")]
	public long Width { get; set; }

	/// <summary>
	/// Высота.
	/// </summary>
	[JsonPropertyName("height")]
	public long Height { get; set; }

	/// <summary>
	/// Ссылка фото пользователя/сообщества.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }
}