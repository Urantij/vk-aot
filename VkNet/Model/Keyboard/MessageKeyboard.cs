using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект клавиатуры, отправляемой ботом.
/// </summary>
[Serializable]
public class MessageKeyboard
{
	/// <summary>
	/// Скрыть клавиатуру сразу же после нажатия на кнопку.
	/// </summary>
	[JsonPropertyName("one_time")]
	public bool OneTime { get; set; }

	/// <summary>
	/// Должна ли клавиатура отображаться внутри сообщения.
	/// </summary>
	[JsonPropertyName("inline")]
	public bool Inline { get; set; }

	/// <summary>
	/// Массив кнопок отправляемых ботом, размером до 4х10
	/// </summary>
	[JsonPropertyName("buttons")]
	public IEnumerable<IEnumerable<MessageKeyboardButton>> Buttons { get; set; }
}