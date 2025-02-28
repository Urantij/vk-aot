using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Заметка пользователя.
/// </summary>
/// <remarks>
/// <a href="http://vk.com/dev/note">См. описание</a>
/// </remarks>
[Serializable]
public class Note : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "note";

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
	/// Дата создания заметки.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Количество комментариев к заметке.
	/// </summary>
	[JsonPropertyName("comments")]
	public int? CommentsCount { get; set; }

	/// <summary>
	/// Количество прочитанных комментариев (только при запросе информации о заметке
	/// текущего пользователя).
	/// </summary>
	[JsonPropertyName("read_comments")]
	public int? ReadCommentsCount { get; set; }

	/// <summary>
	/// Адрес страницы для отображения заметки.
	/// </summary>
	[JsonPropertyName("view_url")]
	public Uri ViewUrl { get; set; }
}