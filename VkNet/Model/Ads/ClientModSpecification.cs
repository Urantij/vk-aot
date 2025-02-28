using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Массив объектов ClientModSpecification
/// </summary>
[Serializable]
public class ClientModSpecification
{
	/// <summary>
	/// Идентификатор редактируемого клиента.
	/// </summary>
	[JsonPropertyName("client_id")]
	public long ClientId { get; set; }

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