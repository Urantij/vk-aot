using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат получения информации о музыкантах
/// </summary>
[Serializable]
public class GetMusiciansResult
{
	/// <summary>
	/// Идентификатор музыканта.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Полный псевдоним музыканта.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Аватарка музыканта.
	/// </summary>
	[JsonPropertyName("avatar")]
	public string Avatar { get; set; }
}