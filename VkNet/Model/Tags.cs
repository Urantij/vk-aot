using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Теги.
/// </summary>
[Serializable]
public class Tags
{
	/// <summary>
	/// Количество.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }
}