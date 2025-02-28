using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат получения целевых пикселей
/// </summary>
[Serializable]
public class GetTargetPixelsResult
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("target_pixel_id")]
	public long TargetPixelId { get; set; }

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
	[JsonPropertyName("category_id")]
	public long CategoryId { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("pixel")]
	public string Pixel { get; set; }
}