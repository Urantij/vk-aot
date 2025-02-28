using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода wall.addComment
/// </summary>
[Serializable]
public class BoardTopicParams
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
}