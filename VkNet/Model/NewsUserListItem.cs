using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Элемент пользовательского списка новостей
/// </summary>
[Serializable]
public class NewsUserListItem
{
	/// <summary>
	/// Идентификатор списка.
	/// </summary>
	[JsonPropertyName("id")]
	public int Id { get; set; }

	/// <summary>
	/// Название списка, заданное пользователем.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Отключены ли копии постов;
	/// </summary>
	[JsonPropertyName("no_reposts")]
	public bool? NoReposts { get; set; }

	/// <summary>
	/// Идентификаторы пользователей и сообществ, включенных в список.
	/// </summary>
	[JsonPropertyName("source_ids")]
	public IEnumerable<long> SourceIds { get; set; }
}