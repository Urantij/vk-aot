using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о военной службе пользователя.
/// </summary>
[Serializable]
public class Military
{
	/// <summary>
	/// Номер части.
	/// </summary>
	[JsonPropertyName("unit")]
	public string Unit { get; set; }

	/// <summary>
	/// Идентификатор части в базе данных.
	/// </summary>
	[JsonPropertyName("unit_id")]
	public ulong? UnitId { get; set; }

	/// <summary>
	/// Идентификатор страны, в которой находится часть.
	/// </summary>
	[JsonPropertyName("country_id")]
	public long? CountryId { get; set; }

	/// <summary>
	/// Год начала службы.
	/// </summary>
	[JsonPropertyName("from")]
	public int? From { get; set; }

	/// <summary>
	/// Год окончания службы.
	/// </summary>
	[JsonPropertyName("until")]
	public int? Until { get; set; }
}