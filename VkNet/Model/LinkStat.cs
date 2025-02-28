using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Ссылка на статистику
/// </summary>
[Serializable]
public class LinkStat
{
	/// <summary>
	/// Время начала отсчета
	/// </summary>
	[JsonPropertyName("timestamp")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Timestamp { get; set; }

	/// <summary>
	/// Общее число переходов
	/// </summary>
	[JsonPropertyName("views")]
	public uint Views { get; set; }

	/// <summary>
	/// Половозрастная статистика
	/// </summary>
	[JsonPropertyName("sex_age")]
	public ReadOnlyCollection<SexAge> SexAge { get; set; }

	/// <summary>
	/// Статистика по странам
	/// </summary>
	[JsonPropertyName("countries")]
	public ReadOnlyCollection<CountriesStats> Countries { get; set; }

	/// <summary>
	/// Статистика по городам
	/// </summary>
	[JsonPropertyName("cities")]
	public ReadOnlyCollection<CitiesStats> Cities { get; set; }
}