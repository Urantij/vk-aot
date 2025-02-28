using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Список владельцев чата
/// </summary>
[Serializable]
public class PrivacyViewListOwners
{
	/// <summary>
	/// Категория
	/// </summary>
	[JsonPropertyName("allowed")]
	public List<long> Allowed { get; set; }

	/// <summary>
	/// Категория
	/// </summary>
	[JsonPropertyName("excluded")]
	public List<long> Excluded { get; set; }
}