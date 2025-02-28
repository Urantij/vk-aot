using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Кнопка клавиатуры, отправляемая ботом.
/// </summary>
[Serializable]
public class MessageKeyboardButton
{
	/// <summary>
	/// Информация содержащаяся в кнопке
	/// </summary>
	[JsonPropertyName("action")]
	public MessageKeyboardButtonAction Action { get; set; }

	/// <summary>
	/// Цвет кнопки
	/// </summary>
	[JsonPropertyName("color")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public KeyboardButtonColor? Color { get; set; }
}