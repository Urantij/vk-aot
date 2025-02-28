using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Удаление/выход участника из сообщества
/// </summary>
[Serializable]
public class GroupLeave : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Самостоятельный ли был выход
	/// </summary>
	[JsonPropertyName("self")]
	public bool? IsSelf { get; set; }
}