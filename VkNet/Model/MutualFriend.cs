using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Общий друг
/// </summary>
[Serializable]
public class MutualFriend
{
	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Идентификаторы общих друзей
	/// </summary>
	[JsonPropertyName("common_friends")]
	public ReadOnlyCollection<ulong> CommonFriends { get; set; }

	/// <summary>
	/// Количество общих друзей
	/// </summary>
	[JsonPropertyName("common_count")]
	public ulong CommonCount { get; set; }
}