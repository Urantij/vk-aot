using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// API Notification object.
/// </summary>
[Serializable]
public class Notification
{
	/// <summary>
	/// Тип оповещения.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Время появления ответа в формате Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Объект описывающий поступивший ответ.
	/// </summary>
	[JsonPropertyName("feedback")]
	public Feedback Feedback { get; set; }

	/// <summary>
	/// объект, описывающий комментарий текущего пользователя, отправленный в ответ на
	/// данное оповещение. Отсутствует, если
	/// пользователь ещё не давал ответа.
	/// </summary>
	[JsonPropertyName("reply")]
	public Reply Reply { get; set; }

	/// <summary>
	/// Property
	/// </summary>
	[JsonPropertyName("parent")]
	public Feedback Parent { get; set; }
}