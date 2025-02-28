using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода LeadForm.Create
/// </summary>
[Serializable]
public class LeadFormCreateResult
{
	/// <summary>
	/// Идентификатор формы
	/// </summary>
	[JsonPropertyName("form_id")]
	public long? FormId { get; set; }

	/// <summary>
	/// Ссылка на форму
	/// </summary>
	[JsonPropertyName("url")]
	public Uri Url { get; set; }
}