using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о медиавложении в записи.
/// См. описание http://vk.com/dev/attachments_w
/// </summary>
[Serializable]
[JsonConverter(typeof(AttachmentJsonConverter))]
public class Attachment
{
	/// <summary>
	/// Экземпляр самого прикрепления.
	/// </summary>
	public MediaAttachment Instance { get; set; }

	/// <summary>
	/// Информация о типе вложения.
	/// </summary>
	public Type Type { get; set; }
}