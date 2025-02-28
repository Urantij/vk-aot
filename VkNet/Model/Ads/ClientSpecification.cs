using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Массив объектов UserSpecification
/// </summary>
[Serializable]
public class ClientSpecification
{
	/// <summary>
	/// Общий лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("all_limit")]
	public long AllLimit { get; set; }

	/// <summary>
	/// Дневной лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("day_limit")]
	public long DayLimit { get; set; }

	/// <summary>
	/// Название объявления.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}