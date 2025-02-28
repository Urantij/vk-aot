using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о статусе пользователя.
/// См. описание http://vk.com/dev/status.get
/// </summary>
[Serializable]
public class Status
{
	/// <summary>
	/// Текст статуса.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Информация об играющей в текущей момент у пользователя аудиокомпозиции.
	/// </summary>
	[JsonPropertyName("audio")]
	public Audio Audio { get; set; }
}