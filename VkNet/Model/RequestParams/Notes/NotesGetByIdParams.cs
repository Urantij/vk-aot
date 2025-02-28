using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Notes Get By Id Params
/// </summary>
[Serializable]
public class NotesGetByIdParams
{
	/// <summary>
	/// идентификатор заметки (обязательный параметр).
	/// </summary>
	[JsonPropertyName("note_id")]
	public long? NoteId { get; set; }

	/// <summary>
	/// идентификатор владельца заметки (по умолчанию идентификатор текущего пользователя).
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// определяет, требуется ли в ответе wiki-представление заметки
	///(работает, только если запрашиваются заметки текущего пользователя).
	/// </summary>
	[JsonPropertyName("need_wiki")]
	public bool? IsNeedWiki { get; set; }
}