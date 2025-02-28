using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода messages.GetHistoryAttachments
/// </summary>
[Serializable]
public class GetHistoryAttachmentsResult
{
	/// <summary>
	/// Идентификатор следующей пачки результатов
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }

	/// <summary>
	/// Беседы
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<HistoryAttachment> Items { get; set; }

	/// <summary>
	/// Массив объектов пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }
}