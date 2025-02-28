using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Приложение.
/// </summary>
[Serializable]
public class AppGetScopesResult
{
	/// <summary>
	/// Количество
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Элементы
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<AppGetScopes> Items { get; set; }
}