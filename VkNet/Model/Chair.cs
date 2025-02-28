using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Кафедра
/// </summary>
[Serializable]
public class Chair
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