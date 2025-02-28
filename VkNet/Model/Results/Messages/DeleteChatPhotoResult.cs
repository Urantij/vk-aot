using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Messages.DeleteChatPhoto
/// </summary>
[Serializable]
public class DeleteChatPhotoResult
{
	/// <summary>
	/// Общее число результатов
	/// </summary>
	[JsonPropertyName("message_id")]
	public long MessageId { get; set; }

	/// <summary>
	/// Массив объектов бесед
	/// </summary>
	[JsonPropertyName("chat")]
	public Chat Chat { get; set; }
}