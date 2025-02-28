using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект, который содержит сообщение и информацию о доступных пользователю функциях.
/// </summary>
[Serializable]
public class MessageEvent : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор чата.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long? PeerId { get; set; }

	/// <summary>
	/// Идентификатор чата.
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; set; }

	/// <summary>
	/// Идентификатор чата.
	/// </summary>
	[JsonPropertyName("payload")]
	[JsonConverter(typeof(MessageEventPayloadJsonConverter))]
	public string Payload { get; set; }

	/// <summary>
	/// Идентификатор сообщения в чате.
	/// </summary>
	[JsonPropertyName("conversation_message_id")]
	public long? ConversationMessageId { get; set; }
}