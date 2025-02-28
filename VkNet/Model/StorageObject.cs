using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ метода Storage.Get
/// </summary>
[Serializable]
public class StorageObject
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