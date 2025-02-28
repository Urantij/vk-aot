using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, с помощью которого можно подключиться к серверу быстрых сообщений для
/// мгновенного
/// получения приходящих сообщений и других событий.
/// См. описание http://vk.com/dev/messages.getLongPollServer
/// </summary>
[Serializable]
public class LongPollServerResponse
{
	/// <summary>
	/// Ключ для подключения.
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Имя сервера быстрых сообщений.
	/// </summary>
	[JsonPropertyName("server")]
	public string Server { get; set; }

	/// <summary>
	/// Номер последнего события, начиная с которого нужно получать данные;
	/// </summary>
	[JsonPropertyName("ts")]
	public ulong Ts { get; set; }

	/// <summary>
	/// Постоянное событие для работы с методом getLongPollHistory
	/// </summary>
	[JsonPropertyName("pts")]
	public ulong? Pts { get; set; }
}