using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление голоса в публичном опросе
/// </summary>
[Serializable]
public class PollVoteNew : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор опроса
	/// </summary>
	[JsonPropertyName("poll_id")]
	public long? PollId { get; set; }

	/// <summary>
	/// Идентификатор варианта ответа
	/// </summary>
	[JsonPropertyName("option_id")]
	public long? OptionId { get; set; }

	/// <summary>
	/// Идентификатор владельца опроса
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }
}