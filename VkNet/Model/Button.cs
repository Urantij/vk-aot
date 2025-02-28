using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Кнопка.
/// </summary>
[Serializable]
public class Button
{
	/// <summary>
	/// Название кнопки.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Ссылка на которую ведет кнопка.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Uri { get; set; }

	/// <summary>
	/// Действие
	/// </summary>
	[JsonPropertyName("action")]
	public LinkButtonAction Action { get; set; }
}