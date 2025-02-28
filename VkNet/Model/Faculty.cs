using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Факультет
/// </summary>
[Serializable]
public class Faculty
{
	/// <summary>
	/// Идентификатор факультета
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название факультета
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }
}