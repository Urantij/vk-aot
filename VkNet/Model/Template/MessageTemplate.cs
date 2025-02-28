using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Объект шаблона, отправляемый ботом.
/// </summary>
[Serializable]
public class MessageTemplate
{
	/// <summary>
	/// Тип шаблона.
	/// </summary>
	[JsonPropertyName("type")]
	public TemplateType? Type { get; set; }

	/// <summary>
	/// Массив элементов шаблона.
	/// </summary>
	[JsonPropertyName("elements")]
	public IEnumerable<CarouselElement> Elements { get; set; }
}