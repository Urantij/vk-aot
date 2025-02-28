using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Беседа настройки чата.
/// </summary>
[Serializable]
public class ConversationChatSettings
{
	/// <summary>
	/// Число участников;
	/// </summary>
	[JsonPropertyName("members_count")]
	public long MembersCount { get; set; }

	/// <summary>
	/// Название
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Объект содержит информацию о закреплённом сообщении в беседе.
	/// </summary>
	[JsonPropertyName("pinned_message")]
	public PinnedMessage PinnedMessage { get; set; }

	/// <summary>
	/// Статус текущего пользователя.
	/// </summary>
	[JsonPropertyName("state")]
	public ConversationChatSettingsState? State { get; set; }

	/// <summary>
	/// Изображение-обложка чата.
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Идентификаторы последних пользователей, писавших в чат.
	/// </summary>
	[JsonPropertyName("active_ids")]
	public ReadOnlyCollection<long> ActiveIds { get; set; }

	/// <summary>
	/// Идентификаторы администраторов чата.
	/// </summary>
	[JsonPropertyName("admin_ids")]
	public ReadOnlyCollection<long> AdminIds { get; set; }

	/// <summary>
	/// Идентификатор владельца чата
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Признак группового канала
	/// </summary>
	[JsonPropertyName("is_group_channel")]
	public bool IsGroupChannel { get; set; }

	/// <summary>
	/// Акк
	/// </summary>
	[JsonPropertyName("acl")]
	public Acl Acl { get; set; }
}