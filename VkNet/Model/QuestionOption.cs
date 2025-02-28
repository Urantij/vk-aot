using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Вариант ответа
/// </summary>
[Serializable]
public class QuestionOption
{
	/// <summary>
	/// Ключ ответа (необязательно)
	/// </summary>
	[JsonPropertyName("key")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Key { get; set; }

	/// <summary>
	/// Текст ответа
	/// </summary>
	[JsonPropertyName("label")]
	public string Label { get; set; }
}