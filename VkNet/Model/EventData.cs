using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// действие, которое должно произойти после нажатия на кнопку
/// </summary>
[Serializable]
public class EventData
{
	/// <summary>
	/// Тип действия, которые должно произойти после нажатия на кнопку
	/// </summary>
	[JsonPropertyName("type")]
	public MessageEventType? Type { get; set; }

	/// <summary>
	/// текст, который нужно вывести (максимум 90 символов).
	/// </summary>
	[JsonPropertyName("text")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Text { get; set; }

	/// <summary>
	/// Ссылка, которую необходимо открыть по нажатию на кнопку.
	/// </summary>
	[JsonPropertyName("link")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Uri Link { get; set; }

	/// <summary>
	/// хэш для навигации в приложении, будет передан в строке параметров запуска после символа #
	/// </summary>
	[JsonPropertyName("hash")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Hash { get; set; }

	/// <summary>
	/// Идентификатор вызываемого приложения с типом <see cref="MessageEventType.OpenApp"/>.
	/// </summary>
	[JsonPropertyName("app_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ulong? AppId { get; set; }

	/// <summary>
	/// Идентификатор сообщества, в котором установлено приложение, если требуется открыть в контексте сообщества.
	/// </summary>
	/// <remarks>
	/// Для <see cref="Type"/> со значением <see cref="MessageEventType.OpenApp"/>.
	/// </remarks>
	[JsonPropertyName("owner_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? OwnerId { get; set; }
}