using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса messages.GetConversations
/// </summary>
[Serializable]
public class GetConversationsParams
{
	/// <summary>
	/// Фильтр
	/// </summary>
	[JsonPropertyName("filter")]
	public GetConversationFilter? Filter { get; set; }

	/// <summary>
	/// Список дополнительных полей для пользователей и сообществ.
	/// </summary>
	[JsonPropertyName("fields")]
	public IEnumerable<string> Fields { get; set; }

	/// <summary>
	/// Смещение, необходимое для выборки определенного подмножества результатов.
	/// </summary>
	[JsonPropertyName("offset")]
	public ulong? Offset { get; set; }

	/// <summary>
	/// Максимальное число результатов, которые нужно получить.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong? Count { get; set; }

	/// <summary>
	/// 1 — возвращать дополнительные поля для пользователей и сообществ.
	/// </summary>
	[JsonPropertyName("extended")]
	public bool Extended { get; set; }

	/// <summary>
	/// Идентификатор сообщения, начиная с которого нужно возвращать беседы.
	/// </summary>
	[JsonPropertyName("start_message_id")]
	public ulong? StartMessageId { get; set; }

	/// <summary>
	/// Идентификатор сообщества (для сообщений сообщества с ключом доступа пользователя).
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong? GroupId { get; set; }
}