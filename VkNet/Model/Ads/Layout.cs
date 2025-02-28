using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Слой
/// </summary>
[Serializable]
public class Layout
{
	/// <summary>
	/// Идентификатор объявления.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("campaign_id")]
	public long CampaignId { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("ad_format")]
	public AdFormat AdFormat { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("cost_type")]
	public CostType CostType { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("goal_type")]
	public GoalType GoalType { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("video")]
	public long Video { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("repeat_video")]
	public long RepeatVideo { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("link_url")]
	public Uri LinkUrl { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("link_domain")]
	public Uri LinkDomain { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("link_title")]
	public Uri LinkTitle { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("link_button")]
	public Uri LinkButton { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("preview_link")]
	public Uri PreviewLink { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("image_src")]
	public Uri ImageSrc { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("image_src_2x")]
	public Uri ImageSrc2X { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("icon_src")]
	public Uri IconSrc { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("icon_src_2x")]
	public Uri IconSrc2X { get; set; }
}