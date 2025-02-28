using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// URL, сокращенный с помощью vk.cc.
/// </summary>
[Serializable]
public class ShortLink
{
	/// <summary>
	/// Время создания ссылки в Unixtime
	/// </summary>
	[JsonPropertyName("timestamp")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Timestamp { get; set; }

	/// <summary>
	/// Сокращенный URL.
	/// </summary>
	[JsonPropertyName("short_url")]
	public Uri ShortUrl { get; set; }

	/// <summary>
	/// Оригинальный URL.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Содержательная часть ссылки (после "vk.cc");
	/// </summary>
	[JsonPropertyName("Key")]
	public string Key { get; set; }

	/// <summary>
	/// Ключ для доступа к приватной статистике ссылки;
	/// </summary>
	[JsonPropertyName("access_key")]
	public string AccessKey { get; set; }

	/// <summary>
	/// Число переходов
	/// </summary>
	[JsonPropertyName("views")]
	public int Views { get; set; }
}