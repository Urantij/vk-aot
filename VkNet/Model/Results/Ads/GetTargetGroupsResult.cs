using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат получения информации о целевых группах
/// </summary>
[Serializable]
public class GetTargetGroupsResult
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("last_updated")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime LastUpdated { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("pixel")]
	public string Pixel { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("is_audience")]
	public bool IsAudience { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("is_shared")]
	public bool IsShared { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("audience_count")]
	public long AudienceCount { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("lifetime")]
	public long Lifetime { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("file_source")]
	public long FileSource { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("api_source")]
	public long ApiSource { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("lookalike_source")]
	public long LookalikeSource { get; set; }
}