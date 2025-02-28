using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода wall.addComment
/// </summary>
[Serializable]
public class BoardEditTopicParams
{
	/// <summary>
	/// Идентификатор сообщества, в котором находится обсуждение.положительное число,
	/// обязательный параметр
	/// </summary>
	[JsonPropertyName("group_id")]
	public long GroupId { get; set; }

	/// <summary>
	/// Идентификатор сообщества, в котором находится обсуждение.положительное число,
	/// обязательный параметр
	/// </summary>
	[JsonPropertyName("topic_id")]
	public long TopicId { get; set; }

	/// <summary>
	/// Новое название обсуждения. Обязательный параметр.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

}