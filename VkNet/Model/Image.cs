using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Копия изображения обложки.
/// </summary>
[Serializable]
public class Image
{
	/// <summary>
	/// URL копии;
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Ширина копии;
	/// </summary>
	[JsonPropertyName("width")]
	public int Width { get; set; }

	/// <summary>
	/// Высота копии.
	/// </summary>
	[JsonPropertyName("height")]
	public int Height { get; set; }
}