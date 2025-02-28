using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода GetCategories
/// </summary>
[Serializable]
public class GetCategoriesResult
{
	/// <summary>
	/// Массив объектов описывающих устаревшие тематики
	/// </summary>
	[JsonPropertyName("v1")]
	public ReadOnlyCollection<AdsCategories> V1 { get; set; }

	/// <summary>
	/// Массив объектов описывающих актуальные тематики
	/// </summary>
	[JsonPropertyName("v2")]
	public ReadOnlyCollection<AdsCategories> V2 { get; set; }
}