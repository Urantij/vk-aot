using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ключевые слова
/// </summary>
[Serializable]
public class StickersKeywords
{
	/// <summary>
	/// базовый URL для стикеров
	/// </summary>
	[JsonPropertyName("base_url")]
	public string BaseUrl { get; set; }

	/// <summary>
	/// Количество объектов
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Коллекция объектов, описывающих подсказки
	/// </summary>
	[JsonPropertyName("dictionary")]
	public List<Hint> Dictionary { get; set; }
}