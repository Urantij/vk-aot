using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Иконка
/// </summary>
[Serializable]
public class Icon
{
	/// <summary>
	/// URL иконки
	/// </summary>
	[JsonPropertyName("base_url")]
	public string BaseUrl { get; set; }
}