using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Результат метода получения статистики о демографии
/// </summary>
[Serializable]
public class GetDemographicsResult
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("stats")]
	public ReadOnlyCollection<DemographicsStats> Stats { get; set; }

	/// <summary>
	/// обязательный параметр, строка
	/// </summary>
	[JsonPropertyName("type")]
	public IdsType? Type { get; set; }
}