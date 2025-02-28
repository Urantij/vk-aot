using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Cсылка для перехода из истории
/// </summary>
[Serializable]
public class StoryLink
{
	/// <summary>
	/// Текст ссылки
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// URL для перехода.
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }
}