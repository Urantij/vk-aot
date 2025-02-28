using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Результат запроса groups.getBanned
/// </summary>
[Serializable]
public class GetBannedResult
{
	/// <summary>
	/// Тип
	/// </summary>
	[JsonPropertyName("type")]
	public SearchResultType? Type { get; set; }

	/// <summary>
	/// Информация о сообществе (для type = group)
	/// </summary>
	[JsonPropertyName("group")]
	public Group Group { get; set; }

	/// <summary>
	/// Информация о пользователе (для type = profile)
	/// </summary>
	[JsonPropertyName("profile")]
	public User Profile { get; set; }

	/// <summary>
	/// Информация о блокировке в сообществе.
	/// </summary>
	[JsonPropertyName("ban_info")]
	public BanInfo BanInfo { get; set; }
}