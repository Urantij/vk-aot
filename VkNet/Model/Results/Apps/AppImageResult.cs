using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Копия изображения обложки.
/// </summary>
[Serializable]
public class AppImageResult
{
	/// <summary>
	/// Общее число результатов
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Массив объектов, описывающих изображения
	/// </summary>
	[JsonPropertyName("items")]
	public IEnumerable<AppImage> Items { get; set; }
}