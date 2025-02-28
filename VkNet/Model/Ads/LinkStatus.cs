using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// API LinkStatus object.
/// </summary>
[Serializable]
public class LinkStatus
{
	/// <summary>
	/// URL
	/// </summary>
	[JsonPropertyName("redirect_url")]
	public string RedirectUrl { get; set; }

	/// <summary>
	/// Link status
	/// </summary>
	[JsonPropertyName("status")]
	public LinkStatusType? Status { get; set; }

	/// <summary>
	/// Reject reason
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }
}