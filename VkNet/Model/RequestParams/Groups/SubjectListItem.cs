using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Элемент списка возможных тематик
/// </summary>
[Serializable]
public class SubjectListItem
{
	/// <summary>
	/// идентификатор тематики;
	/// </summary>
	[JsonPropertyName("id")]
	public int Id { get; set; }

	/// <summary>
	/// название тематики.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}