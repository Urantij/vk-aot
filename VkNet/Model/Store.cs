using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Магазин.
/// </summary>
[Serializable]
public class Store
{
	/// <summary>
	/// Идентификатор магазина;.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Название магазина;.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}