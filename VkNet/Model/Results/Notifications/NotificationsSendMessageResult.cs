using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Notifications.SendMessage
/// </summary>
[Serializable]
public class NotificationsSendMessageResult
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// Статус уведомления
	/// </summary>
	[JsonPropertyName("status")]
	public bool Status { get; set; }

	/// <summary>
	/// Ошибка отправки уведомления
	/// </summary>
	[JsonPropertyName("error")]
	public NotificationsSendMessageError Error { get; set; }
}