using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Комментарий к записи.
/// См. описание <see href="https://vk.com/dev/objects/comment" />.
/// </summary>
[DebuggerDisplay("Id = {Id}, Text = {Text}, Date = {Date}")]
[Serializable]
public class Comment
{
	/// <summary>
	/// Идентификатор комментария.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long? FromId { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("post_id")]
	public long? PostId { get; set; }

	/// <summary>
	/// Идентификатор фотографии.
	/// </summary>
	[JsonPropertyName("pid")]
	public long? PhotoId { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("parents_stack")]
	public ReadOnlyCollection<long> ParentsStack { get; set; }

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("thread")]
	public CommentThread Thread { get; set; }

	/// <summary>
	/// Дата и время создания комментария.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Текст комментария.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Информация о VK Donut.
	/// </summary>
	[JsonPropertyName("donut")]
	public CommentDonut Donut { get; set; }

	/// <summary>
	/// Идентификатор пользователя или сообщества, в ответ которому оставлен текущий
	/// комментарий (если применимо).
	/// </summary>
	[JsonPropertyName("reply_to_user")]
	public long? ReplyToUser { get; set; }

	/// <summary>
	/// Идентификатор комментария, в ответ на который оставлен текущий комментарий
	/// (если применимо).
	/// </summary>
	[JsonPropertyName("reply_to_comment")]
	public long? ReplyToComment { get; set; }

	/// <summary>
	/// Объект, содержащий информацию о медиавложениях в комментарии. См. описание
	/// формата медиавложений.
	/// </summary>
	// [JsonConverter(typeof(AttachmentJsonConverter))]
	[JsonPropertyName("attachments")]
	public ReadOnlyCollection<Attachment> Attachments { get; set; }

	/// <summary>
	/// Первое приложение к комментарию.
	/// </summary>
	public Attachment Attachment => Attachments.FirstOrDefault();

	#region Поля, установленные экспериментально

	/// <summary>
	/// Информация о числе людей, которым понравился данный комментарий.
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	#endregion
}