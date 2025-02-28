using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Превью чата
/// </summary>
[Serializable]
public class ChatPreview
{
	/// <summary>
	/// Информация о чате.
	/// </summary>
	[JsonPropertyName("preview")]
	public ChatPreviewField Preview { get; set; }

	/// <summary>
	/// Массив объектов пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public IEnumerable<User> Profiles { get; set; }

	/// <summary>
	/// Массив объектов сообществ
	/// </summary>
	[JsonPropertyName("groups")]
	public IEnumerable<Group> Groups { get; set; }

	/// <summary>
	/// Массив объектов, описывающих e-mail.
	/// </summary>
	[JsonPropertyName("emails")]
	public IEnumerable<Email> Emails { get; set; }
}