using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметр запроса
/// </summary>
[Serializable]
public class RequestParam
{
	/// <summary>
	/// Ключ
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// Значение
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }
}