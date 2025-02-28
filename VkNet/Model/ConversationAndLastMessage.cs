using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Беседы
/// </summary>
[Serializable]
public class ConversationAndLastMessage
{
	/// <summary>
	/// Объект беседы
	/// </summary>
	[JsonPropertyName("conversation")]
	public Conversation Conversation { get; set; }

	/// <summary>
	/// Объект, описывающий последнее сообщение в беседе.
	/// </summary>
	[JsonPropertyName("last_message")]
	public Message LastMessage { get; set; }
}