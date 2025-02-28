using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Subscription
/// </summary>
[Serializable]
public class PostDonut
{
	/// <summary>
	/// Запись доступна только платным подписчикам VK Donut.
	/// </summary>
	[JsonPropertyName("is_donut")]
	public bool IsDonut { get; set; }

	/// <summary>
	/// Время, в течение которого запись будет доступна только платным подписчикам VK Donut.
	/// </summary>
	[JsonPropertyName("paid_duration")]
	public int? PaidDuration { get; set; }

	/// <summary>
	/// Заглушка для пользователей, которые не оформили подписку VK Donut.
	/// Отображается вместо содержимого записи.
	/// </summary>
	[JsonPropertyName("placeholder")]
	public string Placeholder { get; set; }

	/// <summary>
	/// Можно ли открыть запись для всех пользователей, а не только подписчиков VK Donut.
	/// </summary>
	[JsonPropertyName("can_publish_free_copy")]
	public bool? CanPublishFreeCopy { get; set; }

	/// <summary>
	/// Информация о том, какие значения VK Donut можно изменить в записи.
	/// Возможные значения:
	///		all — всю информацию о VK Donut.
	///		duration — время, в течение которого запись будет доступна только платным подписчикам VK Donut.
	/// </summary>
	[JsonPropertyName("edit_mode")]
	public string EditMode { get; set; }
}