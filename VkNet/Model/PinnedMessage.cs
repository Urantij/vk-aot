using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Объект содержит информацию о закреплённом сообщении в беседе.
/// </summary>
[Serializable]
public class PinnedMessage
{
	/// <summary>
	/// Идентификатор сообщения.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Время отправки сообщения в Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Идентификатор отправителя.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Текст сообщения.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Медиавложения сообщения (фотографии, ссылки и т.п.).
	/// </summary>
	[JsonPropertyName("attachments")]
	// [JsonConverter(typeof(AttachmentJsonConverter))]
	public ReadOnlyCollection<Attachment> Attachments { get; set; }

	/// <summary>
	/// Информация о местоположении
	/// </summary>
	[JsonPropertyName("geo")]
	public Geo Geo { get; set; }

	/// <summary>
	/// Массив пересланных сообщений (если есть).
	/// </summary>
	[JsonPropertyName("fwd_messages")]
	public ReadOnlyCollection<Message> ForwardMessages { get; set; }

	/// <summary>
	/// Идентификатор сообщения.
	/// </summary>
	[JsonPropertyName("conversation_message_id")]
	public long ConversationMessageId { get; set; }

	/// <summary>
	/// Текст сообщения.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Клавиатура.
	/// </summary>
	[JsonPropertyName("keyboard")]
	public MessageKeyboard Keyboard { get; set; }
}