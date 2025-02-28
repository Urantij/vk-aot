using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Точки градиента фона опроса.
/// </summary>
[Serializable]
public class PollBackgroundPoint
{
	/// <summary>
	/// Положение точки
	/// </summary>
	[JsonPropertyName("position")]
	public int Position { get; set; }

	/// <summary>
	/// HEX-код цвета точки
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }
}