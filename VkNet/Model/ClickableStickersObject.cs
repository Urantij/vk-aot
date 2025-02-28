using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий кликабельный стикер.
/// </summary>
[Serializable]
public class ClickableStickersObject
{
	/// <summary>
	/// Ширина оригинального фото или видео.
	/// </summary>
	[JsonPropertyName("original_width")]
	public int OriginalWidth { get; set; }

	/// <summary>
	/// Ширина оригинального фото или видео.
	/// </summary>
	[JsonPropertyName("original_height")]
	public int OriginalHeight { get; set; }

	/// <summary>
	/// Массив объектов кликабельных стикеров.
	/// </summary>
	[JsonPropertyName("clickable_stickers")]
	public IEnumerable<ClickableSticker> ClickableStickers { get; set; }
}