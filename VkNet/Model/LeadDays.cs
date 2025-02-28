using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Days
/// </summary>
[Serializable]
public class LeadDays
{
	/// <summary>
	/// Amount of spent votes
	/// </summary>
	[JsonPropertyName("spent")]
	public int? Spent { get; set; }

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
	/// Started offers number
	/// </summary>
	[JsonPropertyName("started")]
	public int? Started { get; set; }
}