using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// ответ на вопрос
/// </summary>
[Serializable]
public class LeadAnswer
{
	/// <summary>
	/// ключ ответа (в случае, если был задан при создании формы)
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// текст ответа
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; }
}