using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий кликабельный стикер.
/// </summary>
[Serializable]
public class ClickableSticker
{
	/// <summary>
	/// Тип стикера.
	/// </summary>
	[JsonPropertyName("type")]
	[JsonConverter(typeof(JsonStringEnumConverter<ClickableStickerType>))]
	public ClickableStickerType Type { get; set; }

	/// <summary>
	/// Массив точек с координатами кликабельной области. Каждый элемент — объект с двумя координатами точки x, y (int).
	/// Желательно передавать прямоугольную область из четырех точек.
	/// </summary>
	[JsonPropertyName("clickable_area")]
	public IEnumerable<VkPoint> ClickableArea { get; set; }

	/// <summary>
	/// Содержит строку в формате упоминания ВКонтакте, например: [id1|name] или [club1|name].
	/// </summary>
	[JsonPropertyName("mention")]
	public string Mention { get; set; }

	/// <summary>
	/// Содержит строку в формате хештега. Должна обязательно начинаться с символа #.
	/// </summary>
	[JsonPropertyName("hashtag")]
	public string Hashtag { get; set; }

	/// <summary>
	/// Визуальный стиль стикера.
	/// </summary>
	[JsonPropertyName("style")]
	public string Style { get; set; }
}