using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика демографии
/// </summary>
[Serializable]
public class DemographicsStats
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("day")]
	public string Day { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("month")]
	public string Month { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("overall")]
	public string OverAll { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("sex")]
	public ReadOnlyCollection<StatsSexAgeCities> Sex { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("age")]
	public ReadOnlyCollection<StatsSexAgeCities> Age { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("sex_age")]
	public ReadOnlyCollection<StatsSexAgeCities> SexAge { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("cities")]
	public ReadOnlyCollection<StatsSexAgeCities> Cities { get; set; }
}