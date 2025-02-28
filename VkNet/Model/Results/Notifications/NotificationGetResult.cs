using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат запроса
/// </summary>
[Serializable]
public class NotificationGetResult
{
	/// <summary>
	/// Количество уведомлений
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив оповещений для текущего пользователя.
	/// </summary>
	[JsonPropertyName("items")]
	public List<Notification> Items { get; set; }

	/// <summary>
	/// Информация о пользователях, которые находятся в списке оповещений.
	/// </summary>
	[JsonPropertyName("profiles")]
	public List<User> Profiles { get; set; }

	/// <summary>
	/// Информация о сообществах, которые находятся в списке оповещений.
	/// </summary>
	[JsonPropertyName("groups")]
	public List<Group> Groups { get; set; }

	/// <summary>
	/// Время последнего просмотра пользователем раздела оповещений в формате Unixtime.
	/// </summary>
	[JsonPropertyName("last_viewed")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime LastViewed { get; set; }

	/// <summary>
	/// Строковый идентификатор оповещения, полученного последним в предыдущем вызове
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }
}