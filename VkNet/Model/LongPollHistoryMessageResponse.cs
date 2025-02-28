using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using VkNet.Utils;

// ReSharper disable UnusedAutoPropertyAccessor.Global

// ReSharper disable MemberCanBePrivate.Global

namespace VkNet.Model;

/// <summary>
/// Обновления в личных сообщениях пользователя.
/// </summary>
[Serializable]
public abstract class LongPollHistoryResponse
{
	/// <summary>
	/// Обновления в личных сообщениях пользователя.
	/// </summary>
	public LongPollHistoryResponse() => History = new();

	/// <summary>
	/// История.
	/// </summary>
	[JsonPropertyName("history")]

	// ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
	public List<ReadOnlyCollection<long>> History { get; set; }

	/// <summary>
	/// Количество непрочитанных сообщений
	/// </summary>
	public ulong UnreadMessages { get; set; }

	/// <summary>
	/// Колекция профилей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Колекция профилей.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }

	/// <summary>
	/// Последнее значение параметра new_pts, полученное от Long Poll сервера,
	/// используется для получения действий, которые
	/// хранятся всегда.
	/// </summary>
	[JsonPropertyName("new_pts")]
	public ulong NewPts { get; set; }

	/// <summary>
	/// Если true — это означает, что нужно запросить оставшиеся данные с помощью
	/// запроса с параметром max_msg_id
	/// </summary>
	[JsonPropertyName("more")]
	public bool More { get; set; }
}

/// <inheritdoc />
[Serializable]
public class LongPollHistoryJsonResponse : LongPollHistoryResponse
{
	/// <summary>
	/// Колекция сообщений.
	/// </summary>
	[JsonPropertyName("messages")]
	[VkCollectionConverter<JsonObject>]
	public VkCollection<JsonObject> Messages { get; set; }
}

/// <inheritdoc />
[Serializable]
public class LongPollHistoryMessageResponse : LongPollHistoryResponse
{
	/// <summary>
	/// Колекция сообщений.
	/// </summary>
	[JsonPropertyName("messages")]
	[VkCollectionConverter<Message>]
	public VkCollection<Message> Messages { get; set; }
}