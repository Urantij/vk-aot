using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о заявке на смену имени.
/// </summary>
[Serializable]
public class ChangeNameRequest
{
	/// <summary>
	/// Результат изменений
	/// </summary>
	[JsonPropertyName("changed")]
	public bool Changed { get; set; }

	/// <summary>
	/// Информация о заявке на смену имени
	/// </summary>
	[JsonPropertyName("name_request")]
	public NameRequest NameRequest { get; set; }
}