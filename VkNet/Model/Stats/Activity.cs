using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Activity
/// </summary>
[Serializable]
[JsonConverter(typeof(IgnoreUnexpectedArraysConverter<Activity>))]
public class Activity
{
	/// <summary>
	/// Количество лайков
	/// </summary>
	[JsonPropertyName("likes")]
	public long Likes { get; set; }

	/// <summary>
	/// Количество подписчиков
	/// </summary>
	[JsonPropertyName("subscribed")]
	public long Subscribed { get; set; }

	/// <summary>
	/// Количество неподписавшихся.
	/// </summary>
	[JsonPropertyName("unsubscribed")]
	public long Unsubscribed { get; set; }
}