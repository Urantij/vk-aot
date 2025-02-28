using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Элемент истории смс
/// </summary>
[Serializable]
public class SmsHistoryItem
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор приложения
	/// </summary>
	[JsonPropertyName("app_id")]
	public long AppId { get; set; }

	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Дата
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Сообщение
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }
}