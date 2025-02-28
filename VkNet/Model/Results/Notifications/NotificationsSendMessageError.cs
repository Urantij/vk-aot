using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Ошибка отправки уведомления
/// </summary>
[Serializable]
public class NotificationsSendMessageError
{
	/// <summary>
	/// Код ошибки
	/// </summary>
	[JsonPropertyName("code")]
	public NotificationsSendMessageCode Code { get; set; }

	/// <summary>
	/// Описание ошибки
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }
}