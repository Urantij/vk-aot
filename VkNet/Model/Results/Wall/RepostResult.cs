using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса wall.Repost
/// </summary>
[Serializable]
public class RepostResult
{
	/// <summary>
	/// всегда содержит 1;
	/// </summary>
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	/// <summary>
	/// идентификатор созданной записи;
	/// </summary>
	[JsonPropertyName("post_id")]
	public long? PostId { get; set; }

	/// <summary>
	/// количество репостов объекта с учетом осуществленного;
	/// </summary>
	[JsonPropertyName("reposts_count")]
	public int? RepostsCount { get; set; }

	/// <summary>
	/// число отметок «Мне нравится» у объекта.
	/// </summary>
	[JsonPropertyName("likes_count")]
	public int? LikesCount { get; set; }
}