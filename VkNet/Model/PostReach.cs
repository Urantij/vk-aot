using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика для записи на стене.
/// </summary>
[Serializable]
public class PostReach
{
	/// <summary>
	/// Охват подписчиков.
	/// </summary>
	[JsonPropertyName("reach_subscribers")]
	public long ReachSubscribers { get; set; }

	/// <summary>
	/// Суммарный охват.
	/// </summary>
	[JsonPropertyName("reach_total")]
	public long ReachTotal { get; set; }

	/// <summary>
	/// Переходы по ссылке.
	/// </summary>
	[JsonPropertyName("links")]
	public long Links { get; set; }

	/// <summary>
	/// Переходы в сообщество.
	/// </summary>
	[JsonPropertyName("to_group")]
	public long ToGroup { get; set; }

	/// <summary>
	/// Вступления в сообщество.
	/// </summary>
	[JsonPropertyName("join_group")]
	public long JoinGroup { get; set; }

	/// <summary>
	/// Количество жалоб на запись.
	/// </summary>
	[JsonPropertyName("report")]
	public long Report { get; set; }

	/// <summary>
	/// Количество скрытий записи.
	/// </summary>
	[JsonPropertyName("hide")]
	public long Hide { get; set; }

	/// <summary>
	/// Количество отписавшихся участников.
	/// </summary>
	[JsonPropertyName("unsubscribe")]
	public long Unsubscribe { get; set; }
}