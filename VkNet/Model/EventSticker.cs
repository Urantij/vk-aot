using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Событие стикера
/// </summary>
[Serializable]
public class EventSticker
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// Статус
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }
}