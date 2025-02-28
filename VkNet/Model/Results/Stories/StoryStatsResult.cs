using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект статистики истории.
/// </summary>
[Serializable]
public class StoryStatsResult
{
	/// <summary>
	/// Просмотры.
	/// </summary>
	[JsonPropertyName("views")]
	public StoryStatsObject Views { get; set; }

	/// <summary>
	/// Ответы на историю.
	/// </summary>
	[JsonPropertyName("replies")]
	public StoryStatsObject Replies { get; set; }

	/// <summary>
	/// Число. (?)
	/// </summary>
	[JsonPropertyName("answer")]
	public StoryStatsObject Answer { get; set; }

	/// <summary>
	/// Расшаривания истории.
	/// </summary>
	[JsonPropertyName("shares")]
	public StoryStatsObject Shares { get; set; }

	/// <summary>
	/// Новые подписчики.
	/// </summary>
	[JsonPropertyName("subscribers")]
	public StoryStatsObject Subscribers { get; set; }

	/// <summary>
	/// Скрытия истории.
	/// </summary>
	[JsonPropertyName("bans")]
	public StoryStatsObject Bans { get; set; }

	/// <summary>
	/// Переходы по ссылке.
	/// </summary>
	[JsonPropertyName("open_link")]
	public StoryStatsObject OpenLink { get; set; }
}