using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о доступных пользователю функциях.
/// </summary>
[Serializable]
public class ClientInfo
{
	/// <summary>
	/// Массив кнопок, которые поддерживает клиент.
	/// </summary>
	[JsonPropertyName("button_actions")]
	public KeyboardButtonActionType?[] ButtonActions { get; set; }

	/// <summary>
	/// Поддерживается ли клавиатура ботов клиентом.
	/// </summary>
	[JsonPropertyName("keyboard")]
	public bool Keyboard { get; set; }

	/// <summary>
	/// Поддерживается ли carousel клиентом.
	/// </summary>
	[JsonPropertyName("carousel")]
	public bool Carousel { get; set; }

	/// <summary>
	/// Поддерживается ли inline-клавиатура ботов клиентом.
	/// </summary>
	[JsonPropertyName("inline_keyboard")]
	public bool InlineKeyboard { get; set; }

	/// <summary>
	/// Id используемого языка.
	/// </summary>
	[JsonPropertyName("lang_id")]
	public Language LangId { get; set; }
}