using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Версия страницы
/// </summary>
[Serializable]
public class PageVersion
{
	/// <summary>
	/// идентификатор версии страницы;
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// длина версии страницы в байтах;
	/// </summary>
	[JsonPropertyName("length")]
	public string Length { get; set; }

	/// <summary>
	/// дата редактирования страницы;
	/// </summary>
	[JsonPropertyName("edited")]
	public string Edited { get; set; }

	/// <summary>
	/// идентификатор редактора;
	/// </summary>
	[JsonPropertyName("editor_id")]
	public string EditorId { get; set; }

	/// <summary>
	/// имя редактора.
	/// </summary>
	[JsonPropertyName("editor_name")]
	public string EditorName { get; set; }
}