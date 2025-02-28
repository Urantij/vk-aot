using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Настройка
/// </summary>
[Serializable]
public class TokenPermission
{
	/// <summary>
	/// Битовая маска права доступа
	/// </summary>
	[JsonPropertyName("setting")]
	public long Setting { get; set; }

	/// <summary>
	/// Название права доступа.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}