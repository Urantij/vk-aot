using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о последней активности пользователя.
/// См. описание http://vk.com/dev/messages.getLastActivity
/// </summary>
[Serializable]
public class LastActivity
{
	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Текущий статус пользователя (true - в сети, false - не в сети).
	/// </summary>
	[JsonPropertyName("online")]
	public bool? IsOnline { get; set; }

	/// <summary>
	/// Дата последней активности пользователя.
	/// </summary>
	[JsonPropertyName("time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Time { get; set; }
}