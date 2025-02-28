using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Вариант ответа в опросе
/// </summary>
[Serializable]
public class PollAnswer
{
	/// <summary>
	/// Идентификатор варианта ответа
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Текст ответа
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Кол-во проголосовавших
	/// </summary>
	[JsonPropertyName("votes")]
	public int? Votes { get; set; }

	/// <summary>
	/// Процент текущего ответа ко всем остальным вариантам
	/// </summary>
	[JsonPropertyName("rate")]
	public double? Rate { get; set; }
}