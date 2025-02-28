using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// ССылочная кнопка
/// </summary>
[Serializable]
public class LinkButton
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
	public LinkButtonAction Uri { get; set; }
}