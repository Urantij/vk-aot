using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Габариты товара
/// </summary>
[Serializable]
public class Dimensions
{
	/// <summary>
	/// Ширина в миллиметрах
	/// </summary>
	[JsonPropertyName("width")]
	public int Width { get; set; }

	/// <summary>
	/// Высота в миллиметрах
	/// </summary>
	[JsonPropertyName("height")]
	public int Height { get; set; }

	/// <summary>
	/// Длина в миллиметрах
	/// </summary>
	[JsonPropertyName("length")]
	public int Length { get; set; }
}