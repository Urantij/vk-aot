using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Элемент коллекции тем.
/// </summary>
[Serializable]
public class Topic
{
	/// <summary>
	/// Идентификатор темы.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Заголовок.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }


	/// <summary>
	/// Дата создания (в формате unixtime).
	/// </summary>
	[JsonPropertyName("created")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Created { get; set; }

	/// <summary>
	/// Идентификатор пользователя, создавшего тему.
	/// </summary>
	[JsonPropertyName("created_by")]
	public long CreatedBy { get; set; }

	/// <summary>
	/// Дата последнего сообщения (в формате unixtime).
	/// </summary>
	[JsonPropertyName("updated")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Updated { get; set; }

	/// <summary>
	/// Идентификатор автора последнего комментария в обсуждении (может содержать id
	/// сообщества со знаком минус).
	/// </summary>
	[JsonPropertyName("updated_by")]
	public long UpdatedBy { get; set; }

	/// <summary>
	/// Eсли тема является закрытой (в ней нельзя оставлять сообщения).
	/// </summary>
	[JsonPropertyName("is_closed")]
	public bool IsClosed { get; set; }

	/// <summary>
	/// Если тема является закрепленной (находится в начале списка тем).
	/// </summary>
	[JsonPropertyName("is_fixed")]
	public bool IsFixed { get; set; }

	/// <summary>
	/// Число сообщений в теме.
	/// </summary>
	[JsonPropertyName("comments")]
	public long Comments { get; set; }

	/// <summary>
	/// (только если в поле preview указан флаг 1) — текст первого сообщения.
	/// </summary>
	[JsonPropertyName("first_comment")]
	public string FirstComment { get; set; }

	/// <summary>
	/// (только если в поле preview указан флаг 2) — текст последнего сообщения.
	/// </summary>
	[JsonPropertyName("last_comment")]
	public string LastComment { get; set; }
}