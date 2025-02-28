#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметр отвечает за пересылку сообщений в другие чаты и ответ на сообщение в рамках одной беседы.
/// </summary>
[Serializable]
public class MessageForward
{
	/// <summary>
	/// Владелец сообщений. Стоит передавать, если вы хотите переслать сообщения из сообщества в диалог.
	/// </summary>
	[JsonPropertyName("owner_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор места, из которого необходимо переслать сообщения.
	/// </summary>
	[JsonPropertyName("peer_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? PeerId { get; set; }

	/// <summary>
	/// Массив conversation_message_id сообщений, которые необходимо переслать.
	/// В массив conversation_message_ids можно передать сообщения:
	/// находящиеся в личном диалоге с ботом;
	///	являющиеся исходящими сообщениями бота;
	/// написанными после того, как бот вступил в беседу и появился доступ к сообщениям.
	/// </summary>
	[JsonPropertyName("conversation_message_ids")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<long>? ConversationMessageIds { get; set; }

	/// <summary>
	/// Массив id сообщений.
	/// </summary>
	[JsonPropertyName("message_ids")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<long>? MessageIds { get; set; }

	/// <summary>
	/// Ответ на сообщения.
	/// Стоит передавать, если вы хотите ответить на сообщения в том чате, в котором находятся сообщения.
	/// При этом в conversation_message_ids/message_ids должен находиться только один элемент.
	/// </summary>
	[JsonPropertyName("is_reply")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? IsReply { get; set; }
}