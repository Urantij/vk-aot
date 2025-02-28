using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// информация об ответах на вопросы — массив структур со следующими полями
/// </summary>
[Serializable]
public class LeadAnswerInfo
{
	/// <summary>
	/// ключ вопроса.
	/// </summary>
	[JsonPropertyName("key")]
	public string Key { get; set; }

	/// <summary>
	/// ответ на вопрос
	/// </summary>
	[JsonPropertyName("answer")]
	public LeadAnswer Answer { get; set; }
}