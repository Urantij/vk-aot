using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект с двумя координатами точки x, y.
/// </summary>
[Serializable]
public class VkPoint
{
	/// <summary>
	/// x координата.
	/// </summary>
	[JsonPropertyName("x")]
	public int X { get; set; }

	/// <summary>
	/// y координата.
	/// </summary>
	[JsonPropertyName("y")]
	public int Y { get; set; }
}