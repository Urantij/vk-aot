using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Комментарий к записи на стене.
/// </summary>
[Serializable]
public class WallReply : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "wall_reply";

	/// <summary>
	/// Идентификатор автора комментария.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long? FromId { get; set; }

	/// <summary>
	/// Дата создания комментария в формате Unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Текст комментария.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Информация о лайках к комментарию.
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	/// <summary>
	/// Идентификатор пользователя, в ответ которому был оставлен комментарий;
	/// </summary>
	[JsonPropertyName("reply_to_uid")]
	public long? ReplyToUId { get; set; }

	/// <summary>
	/// Идентификатор комментария, в ответ на который был оставлен текущий.
	/// </summary>
	[JsonPropertyName("reply_to_cid")]
	public long? ReplyToCId { get; set; }

	[JsonPropertyName("comment_id")]
	private long? CommentId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("cid")]
	private long? Cid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("uid")]
	private long? Uid
	{
		get => FromId;
		set => FromId = value;
	}

	[JsonPropertyName("user_id")]
	private long? UserId
	{
		get => FromId;
		set => FromId = value;
	}
}