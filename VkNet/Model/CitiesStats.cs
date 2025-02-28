using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Статистика по городу
/// </summary>
[Serializable]
public class CitiesStats
{
	/// <summary>
	/// идентификатор города;
	/// </summary>
	[JsonPropertyName("city_id")]
	public ulong CityId { get; set; }

	/// <summary>
	/// число переходов из этого города
	/// </summary>
	[JsonPropertyName("views")]
	public ulong Views { get; set; }
}