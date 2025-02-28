using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Обложка аудиоальбома.
/// </summary>
[Serializable]
public class AudioCover
{
	/// <summary>
	/// Uri обложки с максимальным размером 34x34.
	/// </summary>
	[JsonPropertyName("photo_34")]
	public string Photo34 { get; set; }

	/// <summary>
	/// Uri обложки с максимальным размером 68x68.
	/// </summary>
	[JsonPropertyName("photo_68")]
	public string Photo68 { get; set; }

	/// <summary>
	/// Uri обложки с максимальным размером 135x135.
	/// </summary>
	[JsonPropertyName("photo_135")]
	public string Photo135 { get; set; }

	/// <summary>
	/// Uri обложки с максимальным размером 270x270.
	/// </summary>
	[JsonPropertyName("photo_270")]
	public string Photo270 { get; set; }

	/// <summary>
	/// Uri обложки с максимальным размером 300x300.
	/// </summary>
	[JsonPropertyName("photo_300")]
	public string Photo300 { get; set; }

	/// <summary>
	/// Uri обложки с максимальным размером 600x600.
	/// </summary>
	[JsonPropertyName("photo_600")]
	public string Photo600 { get; set; }

	/// <summary>
	/// Ширина изображения обложки.
	/// </summary>
	[JsonPropertyName("width")]
	public long Width { get; set; }

	/// <summary>
	/// Высота изображения обложки.
	/// </summary>
	[JsonPropertyName("height")]
	public long Height { get; set; }
}