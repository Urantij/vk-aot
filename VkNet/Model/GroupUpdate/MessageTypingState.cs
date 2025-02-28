using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, который содержит информацию о статусе печатании
/// </summary>
[Serializable]
public class MessageTypingState : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя, который набирает текст.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long? FromId { get; set; }

	/// <summary>
	/// Идентификатор сообщества, которому пользователь пишет сообщение.
	/// </summary>
	[JsonPropertyName("to_id")]
	public long? ToId { get; set; }

	/// <summary>
	/// Состояние статуса набора текста.
	/// </summary>
	[JsonPropertyName("state")]
	public string State { get; set; }
}