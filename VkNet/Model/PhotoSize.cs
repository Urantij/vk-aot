using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Формат описания размеров фотографи.
/// </summary>
[Serializable]
public class PhotoSize
{
	/// <summary>
	/// Uri копии изображения.
	/// </summary>
	[JsonPropertyName("src")]
	public Uri Src { get; set; }

	/// <summary>
	/// Uri копии изображения.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Ширина копии в пикселах.
	/// </summary>
	[JsonPropertyName("width")]
	public ulong Width { get; set; }

	/// <summary>
	/// Высота копии в пикселах.
	/// </summary>
	[JsonPropertyName("height")]
	public ulong Height { get; set; }

	/// <summary>
	/// Обозначение размера и пропорций копии.
	/// </summary>
	[JsonPropertyName("type")]
	public PhotoSizeType? Type { get; set; }
}