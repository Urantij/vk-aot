using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Настройки уведомлений для беседы
/// </summary>
[Serializable]
public class ChatPushSettings
{
	/// <summary>
	/// Идентификатор собеседника.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long? PeerId { get; set; }

	/// <summary>
	/// Состояние звукового оповещения
	/// </summary>
	[JsonPropertyName("sound")]
	public bool? Sound { get; set; }

	/// <summary>
	/// Неизвестный параметр
	/// </summary>
	[JsonPropertyName("disabled_until")]
	public int? DisabledUntil { get; set; }
}