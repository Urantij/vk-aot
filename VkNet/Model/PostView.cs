using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о просмотрах записи.
/// </summary>
[Serializable]
public class PostView
{
	/// <summary>
	/// Число просмотров записи.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }
}