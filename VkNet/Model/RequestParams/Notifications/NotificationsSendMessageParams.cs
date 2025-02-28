using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода Notifications.SendMessage
/// </summary>
[Serializable]
public class NotificationsSendMessageParams
{
	/// <summary>
	/// Список идентификаторов пользователей, которым нужно отправить уведомление (максимум 100 идентификаторов). список положительных чисел, разделенных запятыми, обязательный параметр
	/// </summary>
	[JsonPropertyName("user_ids")]
	public IEnumerable<ulong> UserIds { get; set; }

	/// <summary>
	/// Текст уведомления. строка, обязательный параметр, максимальная длина 254
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }

	/// <summary>
	/// Содержимое хэша (часть URL в ссылке на приложение вида https://vk.com/app123456#fragment). строка, максимальная длина 2047
	/// </summary>
	[JsonPropertyName("fragment")]
	public string Fragment { get; set; }

	/// <summary>
	/// Строка, по умолчанию immediately
	/// </summary>
	[JsonPropertyName("sending_mode")]
	public string SendingMode { get; set; }

	/// <summary>
	/// Положительное число
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Уникальный (в привязке к API_ID и ID отправителя) идентификатор, предназначенный для предотвращения повторной отправки одинакового сообщения.
	/// Заданный random_id используется для проверки уникальности уведомления в течение часа после отправки. целое число, доступен начиная с версии 5.107
	/// </summary>
	[JsonPropertyName("random_id")]
	public long RandomId { get; set; }
}