using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Метка закладки.
/// </summary>
[Serializable]
public class FaveTag
{
	/// <summary>
	/// Идентификатор метки.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название метки.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}