using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Станция метро
/// </summary>
[Serializable]
public class MetroStation
{
	/// <summary>
	/// Идентификатор станции метро
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Название станции метро
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Цвет ветки станции метро
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }
}