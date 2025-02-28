using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Члены обсуждения
/// </summary>
[Serializable]
public class ConversationMember
{
	/// <summary>
	/// Идентификатор участника беседы
	/// </summary>
	[JsonPropertyName("member_id")]
	public long MemberId { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который пригласил участника;
	/// </summary>
	[JsonPropertyName("invited_by")]
	public long InvitedBy { get; set; }

	/// <summary>
	/// Дата добавления в беседу;
	/// </summary>
	[JsonPropertyName("join_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime JoinDate { get; set; }

	/// <summary>
	/// Является ли пользователь администратором
	/// </summary>
	[JsonPropertyName("is_admin")]
	public bool IsAdmin { get; set; }

	/// <summary>
	/// Может ли текущий пользователь исключить участника.
	/// </summary>
	[JsonPropertyName("can_kick")]
	public bool CanKick { get; set; }
}