using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Беседа
/// </summary>
[Serializable]
public class Conversation
{
	/// <summary>
	/// Информация о собеседнике.
	/// </summary>
	[JsonPropertyName("peer")]
	public Peer Peer { get; set; }

	/// <summary>
	/// Идентификатор последнего прочтенного входящего сообщения.
	/// </summary>
	[JsonPropertyName("in_read")]
	public long InRead { get; set; }

	/// <summary>
	/// Идентификатор последнего прочтенного исходящего сообщения.
	/// </summary>
	[JsonPropertyName("out_read")]
	public long OutRead { get; set; }

	/// <summary>
	/// Число непрочитанных сообщений.
	/// </summary>
	[JsonPropertyName("unread_count")]
	public long? UnreadCount { get; set; }

	/// <summary>
	/// true, если диалог помечен как важный (только для сообщений сообществ).
	/// </summary>
	[JsonPropertyName("important")]
	public bool Important { get; set; }

	/// <summary>
	/// true, если диалог помечен как неотвеченный (только для сообщений сообществ).
	/// </summary>
	[JsonPropertyName("unanswered")]
	public bool Unanswered { get; set; }

	/// <summary>
	/// Настройки Push-уведомлений.
	/// </summary>
	[JsonPropertyName("push_settings")]
	public ConversationPushSettings PushSettings { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь писать в диалог.
	/// </summary>
	[JsonPropertyName("can_write")]
	public ConversationCanWrite CanWrite { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь получать деньги.
	/// </summary>
	[JsonPropertyName("can_receive_money")]
	public bool? CanReceiveMoney { get; set; }

	/// <summary>
	/// Информация о том, может ли пользователь отправлять деньги.
	/// </summary>
	[JsonPropertyName("can_send_money")]
	public bool? CanSendMoney { get; set; }

	/// <summary>
	/// Настройки чата.
	/// </summary>
	[JsonPropertyName("chat_settings")]
	public ConversationChatSettings ChatSettings { get; set; }

	/// <summary>
	/// Идентификатор последнего сообщения.
	/// </summary>
	[JsonPropertyName("last_message_id")]
	public long LastMessageId { get; set; }

	/// <summary>
	/// Клавиатура.
	/// </summary>
	[JsonPropertyName("current_keyboard")]
	public MessageKeyboard CurrentKeyboard { get; set; }
}