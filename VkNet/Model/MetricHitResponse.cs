using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Событие метрики.
/// </summary>
[Serializable]
public class MetricHitResponse
{
	/// <summary>
	/// Redirect link
	/// </summary>
	[JsonPropertyName("redirect_link")]
	public string RedirectLink { get; set; }

	/// <summary>
	/// Information whether request has been processed successfully
	/// </summary>
	[JsonPropertyName("result")]
	public bool? Result { get; set; }
}