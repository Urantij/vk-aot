using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса Messages.Edit
/// </summary>
[Serializable]
public class MessageEditParams
{
	/// <summary>
	/// Идентификатор назначения.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long PeerId { get; set; }

	/// <summary>
	/// Текст сообщения. Обязательный параметр, если не задан параметр attachment.
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }

	/// <summary>
	/// Идентификатор сообщения.
	/// </summary>
	[JsonPropertyName("message_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? MessageId { get; set; }

	/// <summary>
	/// Географическая широта (от -90 до 90).
	/// </summary>
	[JsonPropertyName("lat")]
	public double Latitude { get; set; }

	/// <summary>
	/// Географическая долгота (от -180 до 180).
	/// </summary>
	[JsonPropertyName("long")]
	public double Longitude { get; set; }

	/// <summary>
	/// медиавложения к личному сообщению, перечисленные через запятую.
	/// </summary>
	[JsonPropertyName("attachment")]
	public IEnumerable<MediaAttachment> Attachments { get; set; }

	/// <summary>
	/// 1, чтобы сохранить прикреплённые пересланные сообщения
	/// </summary>
	[JsonPropertyName("keep_forward_messages")]
	public bool? KeepForwardMessages { get; set; }

	/// <summary>
	/// 1, чтобы сохранить прикреплённые внешние ссылки (сниппеты).
	/// </summary>
	[JsonPropertyName("keep_snippets")]
	public bool? KeepSnippets { get; set; }

	/// <summary>
	/// Идентификатор сообщества (для сообщений сообщества с ключом доступа пользователя). положительное число
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// 1 — не создавать сниппет ссылки из сообщения флаг, может принимать значения 1 или 0, по умолчанию
	/// </summary>
	[JsonPropertyName("dont_parse_links")]
	public bool DontParseLinks { get; set; }

	/// <summary>
	/// идентификатор сообщения в беседе
	/// </summary>
	[JsonPropertyName("conversation_message_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? ConversationMessageId { get; set; }

	/// <summary>
	/// Шаблон сообщений
	/// </summary>
	/// <remarks>
	/// Рекомендуется для построения использовать <see cref="ITemplateBuilder" />
	/// </remarks>
	[JsonPropertyName("template")]
	public MessageTemplate Template { get; set; }

	/// <summary>
	/// Клавиатура бота
	/// </summary>
	/// <remarks>
	/// Рекомендуется для построения использовать <see cref="IKeyboardBuilder" />
	/// </remarks>
	[JsonPropertyName("keyboard")]
	public MessageKeyboard Keyboard { get; set; }
}