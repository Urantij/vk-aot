using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Данные для подключения к Streaming API.
/// </summary>
[Serializable]
public class StreamingServerUrl
{
	/// <summary>
	/// Хост для подключения к серверу;
	/// </summary>
	[JsonPropertyName("endpoint")]
	public string Endpoint { get; set; }

	/// <summary>
	/// Ключ доступа. Ключ бессрочный и прекращает действовать только после получения
	/// нового ключа.
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }
}