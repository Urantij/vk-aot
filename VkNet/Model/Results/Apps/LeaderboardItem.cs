using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Элемент журнала лидеров
/// </summary>
[Serializable]
public class LeaderboardItem
{
	/// <summary>
	/// Оценка
	/// </summary>
	[JsonPropertyName("score")]
	public long Score { get; set; }

	/// <summary>
	/// Уровень
	/// </summary>
	[JsonPropertyName("level")]
	public long Level { get; set; }

	/// <summary>
	/// Очки
	/// </summary>
	[JsonPropertyName("points")]
	public long Points { get; set; }

	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }
}