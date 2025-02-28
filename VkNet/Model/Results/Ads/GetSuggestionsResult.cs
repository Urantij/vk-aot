using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат получения подсказок
/// </summary>
[Serializable]
public class GetSuggestionsResult
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
	[JsonPropertyName("desc")]
	public string Desc { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("parent")]
	public string Parent { get; set; }
}