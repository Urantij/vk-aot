using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Просмотры
/// </summary>
[Serializable]
public class Views
{
	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }
}