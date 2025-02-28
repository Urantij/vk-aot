using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий источник пользовательского контента для чат-ботов.
/// Если источником является другое сообщение(например, сообщение от пользователя боту)
/// </summary>
[Serializable]
public class MessageContentSource
{
	/// <summary>
	/// Источник.
	/// </summary>
	[JsonPropertyName("type")]
	public MessageContentSourceType? Type { get; set; }

	/// <summary>
	/// От чьего имени указан peer_id. т.е. вы можете использовать контент из сообщения другой группы.
	/// </summary>
	[JsonPropertyName("owner_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Id диалога
	/// </summary>
	[JsonPropertyName("peer_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? PeerId { get; set; }

	/// <summary>
	/// Id сообщения в беседе. Не путать с message.id профиля.
	/// </summary>
	[JsonPropertyName("conversation_message_id")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? ConversationMessageId { get; set; }

	/// <summary>
	/// Если источником является любой другой контент на платформе (комментарий, пост, фотография и тд.).
	/// </summary>
	[JsonPropertyName("url")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Url { get; set; }
}