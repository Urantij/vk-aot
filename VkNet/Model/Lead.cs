using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика по рекламной акции.
/// </summary>
[Serializable]
public class Lead
{
	/// <summary>
	/// Amount of spent votes
	/// </summary>
	[JsonPropertyName("spent")]
	public int? Spent { get; set; }

	/// <summary>
	/// Started offers number
	/// </summary>
	[JsonPropertyName("started")]
	public int? Started { get; set; }

	/// <summary>
	/// Lead limit
	/// </summary>
	[JsonPropertyName("limit")]
	public int? Limit { get; set; }

	/// <summary>
	/// Property
	/// </summary>
	[JsonPropertyName("days")]
	public LeadDays Days { get; set; }

	/// <summary>
	/// Impressions number
	/// </summary>
	[JsonPropertyName("impressions")]
	public int? Impressions { get; set; }

	/// <summary>
	/// Completed offers number
	/// </summary>
	[JsonPropertyName("completed")]
	public int? Completed { get; set; }

	/// <summary>
	/// Offer cost
	/// </summary>
	[JsonPropertyName("cost")]
	public int? Cost { get; set; }
}