using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Акк
/// </summary>
[Serializable]
public class Acl
{
	/// <summary>
	/// Признак возможности пригласить
	/// </summary>
	[JsonPropertyName("can_invite")]
	public bool CanInvite { get; set; }

	/// <summary>
	/// Признак возможности изменить информацию
	/// </summary>
	[JsonPropertyName("can_change_info")]
	public bool CanChangeInfo { get; set; }

	/// <summary>
	/// Признак возможности изменить закрепление
	/// </summary>
	[JsonPropertyName("can_change_pin")]
	public bool CanChangePin { get; set; }

	/// <summary>
	/// Признак возможности повысить пользователей
	/// </summary>
	[JsonPropertyName("can_promote_users")]
	public bool CanPromoteUsers { get; set; }

	/// <summary>
	/// Признак возможности видеть ссылки на приглашение
	/// </summary>
	[JsonPropertyName("can_see_invite_link")]
	public bool CanSeeInviteLink { get; set; }

	/// <summary>
	/// Признак возможности изменить ссылку на приглашение
	/// </summary>
	[JsonPropertyName("can_change_invite_link")]
	public bool CanChangeInviteLink { get; set; }

	/// <summary>
	/// Признак возможности модерировать
	/// </summary>
	[JsonPropertyName("can_moderate")]
	public bool CanModerate { get; set; }

	/// <summary>
	/// Признак возможности копировать чат
	/// </summary>
	[JsonPropertyName("can_copy_chat")]
	public bool CanCopyChat { get; set; }
}