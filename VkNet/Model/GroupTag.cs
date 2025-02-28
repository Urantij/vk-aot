using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Тэг группы
/// </summary>
[Serializable]
public class GroupTag
{
	/// <summary>
	/// Идентификатор тэга
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Название тэга
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Цвет тэга в формате #ffffff
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }
}