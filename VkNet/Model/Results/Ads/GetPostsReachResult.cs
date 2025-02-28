using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Описание рекламного аккаунта.
/// </summary>
/// <remarks>
/// См. описание https://vk.com/dev/ads.getAccounts
/// </remarks>
[Serializable]
public class GetPostsReachResult
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("reach_subscribers")]
	public long ReachSubscribers { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("reach_total")]
	public long ReachTotal { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("links")]
	public long Links { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("to_group")]
	public long ToGroup { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("join_group")]
	public long JoinGroup { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("report")]
	public long Report { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("hide")]
	public long Hide { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("unsubscribe")]
	public long Unsubscribe { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_start")]
	public long VideoViewsStart { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_3s")]
	public long VideoViews3S { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_25p")]
	public long VideoViews25P { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_50p")]
	public long VideoViews50P { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_75p")]
	public long VideoViews75P { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("video_views_100p")]
	public long VideoViews100P { get; set; }
}