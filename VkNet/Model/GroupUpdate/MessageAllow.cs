using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Подписка на сообщения от сообщества (<c>MessageAllow</c>, ваш капитан!)
/// </summary>
[Serializable]
public class MessageAllow : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Параметр, переданный в методе <c>messages.allowMessagesFromGroup</c>
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }
}