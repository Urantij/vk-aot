using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// История изменения объекта
/// </summary>
[Serializable]
public class History
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Длина символов.
	/// </summary>
	/// <remarks>
	/// При необходимости сделать nullable
	/// </remarks>
	[JsonPropertyName("length")]
	public int Length { get; set; }

	/// <summary>
	/// Дата изменения.
	/// </summary>
	[JsonPropertyName("date")]
	public string Date { get; set; }

	/// <summary>
	/// Идентификатор пользователя применившего изменения.
	/// </summary>
	[JsonPropertyName("editor_id")]
	public long EditorId { get; set; }

	/// <summary>
	/// Имя пользователя применившего изменения.
	/// </summary>
	[JsonPropertyName("editor_name")]
	public string EditorName { get; set; }
}