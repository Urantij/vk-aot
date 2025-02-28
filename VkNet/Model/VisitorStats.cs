using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика посещений
/// </summary>
[Serializable]
public class VisitorStats
{
	/// <summary>
	/// Число просмотров.
	/// </summary>
	[JsonPropertyName("views")]
	public long Views { get; set; }

	/// <summary>
	/// Число посетителей;
	/// </summary>
	[JsonPropertyName("visitors")]
	public long Visitors { get; set; }

	/// <summary>
	/// Число просмотров с мобильных устройств.
	/// </summary>
	[JsonPropertyName("mobile_views")]
	public long MobileViews { get; set; }

	/// <summary>
	/// Статистика по полу.
	/// </summary>
	[JsonPropertyName("sex")]
	public IEnumerable<CountValue> Sex { get; set; }

	/// <summary>
	/// Статистика по возрасту.
	/// </summary>
	[JsonPropertyName("age")]
	public IEnumerable<CountValue> Age { get; set; }

	/// <summary>
	/// Статистика по полу и возрасту.
	/// </summary>
	[JsonPropertyName("sex_age")]
	public IEnumerable<CountValue> SexAge { get; set; }

	/// <summary>
	/// Статистика по странам.
	/// </summary>
	[JsonPropertyName("countries")]
	public IEnumerable<City> Countries { get; set; }

	/// <summary>
	/// Статистика по городам.
	/// </summary>
	[JsonPropertyName("cities")]
	public IEnumerable<City> Cities { get; set; }
}