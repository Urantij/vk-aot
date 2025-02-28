using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат проверки токена.
/// </summary>
[Serializable]
public class CheckTokenResult
{
	/// <summary>
	/// Признак успешности проверки
	/// </summary>
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// Дата.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Дата истечения токена.
	/// </summary>
	[JsonPropertyName("expire")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Expire { get; set; }
}