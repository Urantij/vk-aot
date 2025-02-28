using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.SafetyEnums;

namespace VkNet.Model;

/// <summary>
/// Notes Edit Params
/// </summary>
[Serializable]
public class NotesEditParams
{
	/// <summary>
	/// Идентификатор заметки.
	/// </summary>
	[JsonPropertyName("note_id")]
	public long? NoteId { get; set; }

	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Текст заметки.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Настройки приватности просмотра заметки в специальном формате.
	/// </summary>
	[JsonPropertyName("privacy_view")]
	public List<Privacy> PrivacyView { get; set; }

	/// <summary>
	/// Настройки приватности комментирования заметки в специальном формате.
	/// </summary>
	[JsonPropertyName("privacy_comment")]
	public List<Privacy> PrivacyComment { get; set; }
}