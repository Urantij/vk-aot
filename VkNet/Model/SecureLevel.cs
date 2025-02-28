using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// API Level object.
/// </summary>
[Serializable]
public class SecureLevel
{
	/// <summary>
	/// Level
	/// </summary>
	[JsonPropertyName("level")]
	public int? LevelCode { get; set; }

	/// <summary>
	/// User ID
	/// </summary>
	[JsonPropertyName("uid")]
	public ulong? Uid { get; set; }
}