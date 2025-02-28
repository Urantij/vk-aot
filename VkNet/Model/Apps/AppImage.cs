using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
///  Массив объектов, описывающих изображения
/// </summary>
[Serializable]
public class AppImage
{
	/// <summary>
	/// Идентификатор изображения
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Тип изображения.
	/// </summary>
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	[JsonPropertyName("type")]
	public AppWidgetImageType Type { get; set; }

	/// <summary>
	/// Массив копий изображения
	/// </summary>
	[JsonPropertyName("images")]
	public IEnumerable<Image> Images { get; set; }
}