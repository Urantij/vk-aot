using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий размер обложки видео.
/// См. описание https://vk.com/dev/objects/video_image
/// </summary>
[Serializable]
public class VideoImage
{
	/// <summary>
	/// URL-адрес изображения.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }

	/// <summary>
	/// Ширина изображения.
	/// </summary>
	[JsonPropertyName("width")]
	public ulong Width { get; set; }

	/// <summary>
	/// Высота изображения.
	/// </summary>
	[JsonPropertyName("height")]
	public ulong Height { get; set; }

	/// <summary>
	/// <c>true</c>, если изображение имеет черные поля.
	/// </summary>
	[JsonPropertyName("with_padding")]
	public bool WithPadding { get; set; }
}