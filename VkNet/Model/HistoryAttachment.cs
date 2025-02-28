using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Вложения материалов диалога или беседы
/// </summary>
[Serializable]
public class HistoryAttachment
{
	/// <summary>
	/// Идентификатор сообщения, в котором было отправлено вложение.
	/// </summary>
	[JsonPropertyName("message_id")]
	public int MessageId { get; set; }

	/// <summary>
	/// Информация о вложении.
	/// </summary>
	[JsonPropertyName("attachment")]
	[JsonConverter(typeof(HistoryAttachmentJsonConverter))]
	public Attachment Attachment { get; set; }

	/// <summary>
	/// Тип плейлиста.
	/// </summary>
	[JsonPropertyName("forward_level")]
	public int ForwardLevel { get; set; }

	/// <summary>
	/// Идентификатор вложения
	/// </summary>
	[JsonPropertyName("cmid")]
	public long Cmid { get; set; }

	/// <summary>
	/// Идентификатор владельца
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Дата
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime Date { get; set; }

}