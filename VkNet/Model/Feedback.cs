using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект описывающий поступивший ответ.
/// </summary>
[Serializable]
public class Feedback
{
	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив объектов
	/// </summary>
	[JsonPropertyName("items")]
	public List<FeedbackItem> Items { get; set; }
}