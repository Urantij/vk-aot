using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, который содержит сообщение и информацию о доступных пользователю функциях.
/// </summary>
[Serializable]
public class MessageNew : IGroupUpdate
{
	/// <summary>
	/// Сообщение.
	/// </summary>
	[JsonPropertyName("message")]
	public Message Message { get; set; }

	/// <summary>
	/// Информация о доступных пользователю функциях.
	/// </summary>
	[JsonPropertyName("client_info")]
	public ClientInfo ClientInfo { get; set; }
}