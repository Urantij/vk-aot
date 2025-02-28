using System;
using System.Text.Json.Serialization;
using VkNet.Utils;
using VkNet.Utils.JsonConverter;

// ReSharper disable MemberCanBePrivate.Global

namespace VkNet.Model;

/// <summary>
/// Результат получения запросов в друзья
/// </summary>
[Serializable]
public class FriendsGetRequestsResult
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Общие
	/// </summary>
	[JsonPropertyName("mutual")]
	[VkCollectionConverter<long>("users")]
	public VkCollection<long> Mutual { get; set; }

	/// <summary>
	/// Текст сообщения
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }
}