using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Правила отказа
/// </summary>
[Serializable]
public class RejectionRules
{
	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Параграфы
	/// </summary>
	[JsonPropertyName("paragraphs")]
	public string Paragraphs { get; set; }
}