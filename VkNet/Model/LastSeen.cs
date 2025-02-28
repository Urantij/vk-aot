using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Время последнего посещения.
/// </summary>
[Serializable]
public class LastSeen
{
	/// <summary>
	/// Время последнего посещения в формате unixtime. .
	/// </summary>
	[JsonPropertyName("time")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Time { get; set; }

	/// <summary>
	/// Тип платформы, через которую был осуществлён последний вход. Подробнее cмотрите
	/// на странице Подключение к LongPoll
	/// серверу. .
	/// </summary>
	[JsonPropertyName("platform")]
	public string Platform { get; set; }
}