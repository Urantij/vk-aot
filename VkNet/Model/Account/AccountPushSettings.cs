using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Настройки отправки аккаунта
/// </summary>
[Serializable]
public class AccountPushSettings
{
	/// <summary>
	/// Отключены ли уведомления.
	/// </summary>
	[JsonPropertyName("disabled")]
	public bool Disabled { get; set; }

	/// <summary>
	/// Unixtime-значение времени, до которого временно отключены уведомления.
	/// </summary>
	[JsonPropertyName("disabled_until")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? DisabledUntil { get; set; }

	/// <summary>
	/// Список, содержащий настройки конкретных диалогов, и их количество первым
	/// элементом.
	/// </summary>
	[JsonPropertyName("conversations")]
	public IEnumerable<ChatPushSettings> Conversations { get; set; }

	/// <summary>
	/// Объект с настройками Push-уведомлений в специальном формате.
	/// </summary>
	[JsonPropertyName("settings")]
	public PushSettings Settings { get; set; }
}