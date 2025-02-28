using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода messages.send
/// </summary>
[Serializable]
public class MessagesSendParams
{
	/// <summary>
	/// Короткий адрес пользователя (например, illarionov).
	/// </summary>
	[JsonPropertyName("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// Заголовок сообщения(выделется жирным)
	/// </summary>
	[JsonPropertyName("title")]
	[Obsolete("Свойство официально не поддерживается и может не отображаться в чате.")]
	public string Title { get; set; }

	/// <summary>
	/// Текст личного сообщения (является обязательным, если не задан параметр
	/// attachment)
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }

	/// <summary>
	/// Медиавложения к личному сообщению, перечисленные через запятую.
	/// </summary>
	[JsonPropertyName("attachment")]
	public IEnumerable<MediaAttachment> Attachments { get; set; }

	/// <summary>
	/// Идентификатор сообщения, на которое требуется ответить. целое число, доступен начиная с версии 5.92
	/// </summary>
	[JsonPropertyName("reply_to")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? ReplyTo { get; set; }

	/// <summary>
	/// Идентификаторы пересылаемых сообщений, перечисленные через запятую.
	/// Перечисленные сообщения отправителя будут
	/// отображаться в теле письма у получателя.
	/// </summary>
	[JsonPropertyName("forward_messages")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IEnumerable<long> ForwardMessages { get; set; }

	/// <summary>
	/// Параметр отвечает за пересылку сообщений в другие чаты и ответ на сообщение в рамках одной беседы.
	/// </summary>
	[JsonPropertyName("forward")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public MessageForward Forward { get; set; }

	/// <summary>
	/// Объект, описывающий клавиатуру для бота.
	/// </summary>
	/// <remarks>
	/// Рекомендуется для построения использовать <see cref="IKeyboardBuilder" />
	/// </remarks>
	[JsonPropertyName("keyboard")]
	public MessageKeyboard Keyboard { get; set; }

	/// <summary>
	/// Идентификатор пользователя, которому отправляется сообщение.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Уникальный идентификатор, предназначенный для предотвращения повторной отправки
	/// одинакового сообщения.
	/// Сохраняется вместе с сообщением и доступен в истории сообщений.
	/// </summary>
	[JsonPropertyName("random_id")]
	public long? RandomId { get; set; }

	/// <summary>
	/// Идентификатор назначения. Для групповой беседы: 2000000000 + id беседы. Для
	/// сообщества: -id сообщества.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long? PeerId { get; set; }

	/// <summary>
	/// Идентификаторы назначения. Для групповой беседы: 2000000000 + id беседы. Для
	/// сообщества: -id сообщества. Максимальное количество элементов: 100.
	/// </summary>
	[JsonPropertyName("peer_ids")]
	public IEnumerable<long> PeerIds { get; set; }

	/// <summary>
	/// Идентификатор беседы, к которой будет относиться сообщение.
	/// </summary>
	[JsonPropertyName("chat_id")]
	public long? ChatId { get; set; }

	/// <summary>
	/// Идентификаторы получателей сообщения (при необходимости отправить сообщение
	/// сразу нескольким пользователям).
	/// </summary>
	[JsonPropertyName("user_ids")]
	public IEnumerable<long> UserIds { get; set; }

	/// <summary>
	/// Latitude - широта при добавлении местоположения.
	/// </summary>
	[JsonPropertyName("lat")]
	public double? Lat { get; set; }

	/// <summary>
	/// Longitude - долгота при добавлении местоположения.
	/// </summary>
	[JsonPropertyName("long")]
	public double? Longitude { get; set; }

	/// <summary>
	/// Идентификатор стикера.
	/// </summary>
	[JsonPropertyName("sticker_id")]
	public uint? StickerId { get; set; }

	/// <summary>
	/// Идентификатор сообщества (для сообщений сообщества с ключом доступа
	/// пользователя). положительное число
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Полезная нагрузка (максимальная длина 1000)
	/// </summary>
	[JsonPropertyName("payload")]
	public string Payload { get; set; }

	/// <summary>
	/// Объект, описывающий источник пользовательского контента для чат-ботов
	/// </summary>
	[JsonPropertyName("content_source")]
	public MessageContentSource ContentSource { get; set; }

	/// <summary>
	/// 1 — не создавать сниппет ссылки из сообщения флаг, может принимать значения 1
	/// или 0, по умолчанию
	/// </summary>
	[JsonPropertyName("dont_parse_links")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? DontParseLinks { get; set; }


	/// <summary>
	/// 1 - отключить уведомление об упоминании в сообщении, может принимать значения 1
	/// или 0, по умолчанию
	/// </summary>
	[JsonPropertyName("disable_mentions")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public bool? DisableMentions { get; set; }

	/// <summary>
	/// Метка, которая обозначает приблизительное содержание сообщения от сообщества
	/// </summary>
	[JsonPropertyName("intent")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Intent? Intent { get; set; }

	/// <summary>
	/// Положительное число, максимальное значение 100
	/// </summary>
	[JsonPropertyName("subscribe_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public byte? SubscribeId { get; set; }

	/// <summary>
	/// Объект, описывающий шаблон сообщения для бота.
	/// </summary>
	/// <remarks>
	/// Рекомендуется для построения использовать <see cref="ITemplateBuilder" />
	/// </remarks>
	[JsonPropertyName("template")]
	public MessageTemplate Template { get; set; }
}