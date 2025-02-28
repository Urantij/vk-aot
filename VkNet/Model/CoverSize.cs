using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Размер
/// </summary>
[Serializable]
public class CoverSize
{
	/// <summary>
	/// URL
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Ширина
	/// </summary>
	[JsonPropertyName("width")]
	public long Width { get; set; }

	/// <summary>
	/// Высота
	/// </summary>
	[JsonPropertyName("height")]
	public long Height { get; set; }

	/// <summary>
	/// Тип
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }
}