using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика по стране
/// </summary>
[Serializable]
public class CountriesStats
{
	/// <summary>
	/// идентификатор страны;
	/// </summary>
	[JsonPropertyName("country_id")]
	public ulong CountryId { get; set; }

	/// <summary>
	/// число переходов из этой страны
	/// </summary>
	[JsonPropertyName("views")]
	public ulong Views { get; set; }
}