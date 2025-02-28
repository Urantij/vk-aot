using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Новый запрет сообщений от сообщества (<c>MessageDeny</c>)
/// </summary>
[Serializable]
public class MessageDeny : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }
}