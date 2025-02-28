using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Обложка
/// </summary>
[Serializable]
public class Cover
{
	/// <summary>
	/// Размеры
	/// </summary>
	[JsonPropertyName("sizes")]
	public ReadOnlyCollection<CoverSize> Sizes { get; set; }
}