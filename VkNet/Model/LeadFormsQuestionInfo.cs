using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о вопросах формы.
/// </summary>
[Serializable]
public class LeadFormsQuestionInfo
{
	/// <summary>
	/// Тип вопроса
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Заголовок вопроса (только для нестандартных вопросов)
	/// </summary>
	[JsonPropertyName("label")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Label { get; set; }

	/// <summary>
	/// Уникальный ключ вопроса (необязательно; только для нестандартных вопросов)
	/// </summary>
	[JsonPropertyName("key")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string Key { get; set; }

	/// <summary>
	/// Массив возможных ответов на вопрос (только для нестандартных вопросов типа radio, select, checkbox)
	/// </summary>
	[JsonPropertyName("options")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public QuestionOption[] Options { get; set; }
}