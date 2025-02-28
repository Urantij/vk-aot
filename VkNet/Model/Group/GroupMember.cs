using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о участнике сообщества (группы).
/// См. описание http://vk.com/dev/fields_groups
/// </summary>
[Serializable]
public class GroupMember
{
	#region Стандартные поля

	/// <summary>
	/// Идентификатор пользователя ВК.
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong? UserId { get; set; }

	/// <summary>
	/// Является ли пользователь участником сообщества;
	/// </summary>
	[JsonPropertyName("member")]
	public bool Member { get; set; }

	/// <summary>
	/// Есть ли непринятая заявка от пользователя на вступление в группу (такую заявку
	/// можно отозвать методом
	/// groups.leave).
	/// </summary>
	[JsonPropertyName("request")]
	public bool? Request { get; set; }

	/// <summary>
	/// Приглашён ли пользователь в группу или встречу.
	/// </summary>
	[JsonPropertyName("invitation")]
	public bool? Invitation { get; set; }

	#endregion
}