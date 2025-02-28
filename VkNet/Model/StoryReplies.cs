using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация об ответах на текущую историю.
/// </summary>
[Serializable]
public class StoryReplies
{
	/// <summary>
	/// Число ответов
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Число новых ответов.
	/// </summary>
	[JsonPropertyName("new")]
	public int? New { get; set; }
}