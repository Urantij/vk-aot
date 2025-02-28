using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Онлайн статус
/// </summary>
[Serializable]
public class OnlineStatus
{
	/// <summary>
	/// Статус
	/// </summary>
	[JsonPropertyName("status")]
	public OnlineStatusType? Status { get; set; }

	/// <summary>
	/// Оценка времени ответа в минутах
	/// </summary>
	[JsonPropertyName("minutes")]
	public uint? Minutes { get; set; }
}