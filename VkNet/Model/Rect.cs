using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Вырезанная фотография пользователя
/// </summary>
[Serializable]
public class Rect
{
	/// <summary>
	/// x
	/// </summary>
	[JsonPropertyName("x")]
	public uint X { get; set; }

	/// <summary>
	/// x2
	/// </summary>
	[JsonPropertyName("x2")]
	public uint X2 { get; set; }

	/// <summary>
	/// y
	/// </summary>
	[JsonPropertyName("y")]
	public uint Y { get; set; }

	/// <summary>
	/// y2
	/// </summary>
	[JsonPropertyName("y2")]
	public uint Y2 { get; set; }
}