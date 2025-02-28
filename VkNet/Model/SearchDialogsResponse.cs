using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Ответ при поиске диалогов по строке поиска.
/// См. описание http://vk.com/dev/messages.searchDialogs
/// </summary>
[JsonConverter(typeof(SearchDialogsResponseJsonConverter))]
[Serializable]
public class SearchDialogsResponse
{
	/// <summary>
	/// Список найденных пользователей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public IList<User> Users { get; set; }

	/// <summary>
	/// Список найденных бесед.
	/// </summary>
	[JsonPropertyName("chats")]
	public IList<Chat> Chats { get; set; }

	/// <summary>
	/// Список найденных сообществ.
	/// </summary>
	[JsonPropertyName("groups")]
	public IList<Group> Groups { get; set; }
}