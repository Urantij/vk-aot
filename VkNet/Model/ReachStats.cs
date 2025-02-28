using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Данные об охвате.
/// </summary>
[Serializable]
public class ReachStats
{
	/// <summary>
	/// Полный охват;
	/// </summary>
	[JsonPropertyName("reach")]
	public long Reach { get; set; }

	/// <summary>
	/// Охват подписчиков;
	/// </summary>
	[JsonPropertyName("reach_subscribers")]
	public long ReachSubscribers { get; set; }

	/// <summary>
	/// Охват с мобильных устройств;
	/// </summary>
	[JsonPropertyName("mobile_reach")]
	public long MobileReach { get; set; }

	/// <summary>
	/// Статистика по полу.
	/// </summary>
	[JsonPropertyName("sex")]
	public List<CountValue> Sex { get; set; }

	/// <summary>
	/// Статистика по возрасту.
	/// </summary>
	[JsonPropertyName("age")]
	public List<CountValue> Age { get; set; }

	/// <summary>
	/// Статистика по полу и возрасту.
	/// </summary>
	[JsonPropertyName("sex_age")]
	public List<CountValue> SexAge { get; set; }

	/// <summary>
	/// Статистика по странам.
	/// </summary>
	[JsonPropertyName("countries")]
	public List<City> Countries { get; set; }

	/// <summary>
	/// Статистика по городам.
	/// </summary>
	[JsonPropertyName("cities")]
	public List<City> Cities { get; set; }
}