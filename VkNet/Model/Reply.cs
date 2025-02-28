using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Описание поля reply
/// </summary>
[Serializable]
public class Reply
{
	/// <summary>
	/// Идентификатор комментария
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Время публикации комментария в формате unixtime
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime Date { get; set; }

	/// <summary>
	/// Текст комментария
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}