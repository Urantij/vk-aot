using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса friends.getRequests
/// </summary>
[Serializable]
public class GetRequestsResult
{
	/// <summary>
	/// Total requests number
	/// </summary>
	[JsonPropertyName("count")]
	public uint Count { get; set; }

	/// <summary>
	/// User ID's
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<long> Items { get; set; }

	/// <summary>
	/// Total unread requests number
	/// </summary>
	[JsonPropertyName("count_unread")]
	public uint CountUnread { get; set; }
}