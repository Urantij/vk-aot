using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект, содержащий поле count
/// </summary>
[Serializable]
public class ObjectCount
{
	/// <summary>
	/// количество *** к странице внутри виджета
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }
}