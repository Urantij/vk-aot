using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Настройки уведомлений для сообщений
/// </summary>
[Serializable]
public class MessagesPushSettings
{
	/// <summary>
	/// Отключить звук.
	/// </summary>
	[JsonPropertyName("no_sound")]
	public bool NoSound { get; set; }

	/// <summary>
	/// Не передавать текст сообщения.
	/// </summary>
	[JsonPropertyName("no_text")]
	public bool NoText { get; set; }
}