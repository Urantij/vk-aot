using System;
using System.Text.Json.Serialization;
using VkNet.Utils;

namespace VkNet.Model;

/// <summary>
/// Объект для перечисления пользователей, которые выбрали определенные варианты ответа в опросе.
/// </summary>
[Serializable]
public class PollAnswerVoters
{
	/// <summary>
	/// Идентификатор варианта ответа
	/// </summary>
	[JsonPropertyName("answer_id")]
	public long? AnswerId { get; set; }

	/// <summary>
	/// Коллекция пользователей, только если Fields != null
	/// </summary>
	[JsonPropertyName("users")]
	[VkCollectionConverter<User>]
	public VkCollection<User> Users { get; set; }

	/// <summary>
	/// Коллекция идентификаторов пользователей, только если Fields = null
	/// </summary>
	[JsonPropertyName("items")]
	[VkCollectionConverter<long>]
	public VkCollection<long> UsersIds { get; set; }
}