using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о чате.
/// </summary>
[Serializable]
public class ChatPreviewField
{
	/// <summary>
	/// Идентификатор создателя чата
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long AdminId { get; set; }

	/// <summary>
	/// Массив идентификаторов участников чата
	/// </summary>
	[JsonPropertyName("members")]
	public IEnumerable<long> Members { get; set; }

	/// <summary>
	/// Название чата
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Обложка чата
	/// </summary>
	[JsonPropertyName("photo")]
	public ChatPhoto Photo { get; set; }

	/// <summary>
	/// Идентификатор чата для текущего пользователя
	/// </summary>
	[JsonPropertyName("local_id")]
	public int LocalId { get; set; }
}