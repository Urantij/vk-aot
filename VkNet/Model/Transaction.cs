using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// API Transaction object.
/// </summary>
[Serializable]
public class Transaction
{
	/// <summary>
	/// From ID
	/// </summary>
	[JsonPropertyName("uid_from")]
	public ulong? UidFrom { get; set; }

	/// <summary>
	/// Transaction date in Unixtime
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Votes number
	/// </summary>
	[JsonPropertyName("votes")]
	public int? Votes { get; set; }

	/// <summary>
	/// Transaction ID
	/// </summary>
	[JsonPropertyName("id")]
	public ulong? Id { get; set; }

	/// <summary>
	/// To ID
	/// </summary>
	[JsonPropertyName("uid_to")]
	public ulong? UidTo { get; set; }
}