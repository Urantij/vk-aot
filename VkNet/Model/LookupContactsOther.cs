using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Контактов, который не был найден.
/// </summary>
[Serializable]
public class LookupContactsOther
{
	/// <summary>
	/// Контакт.
	/// </summary>
	[JsonPropertyName("contact")]
	public string Contact { get; set; }

	/// <summary>
	/// Количество.
	/// </summary>
	[JsonPropertyName("common_count")]
	public long CommonCount { get; set; }
}