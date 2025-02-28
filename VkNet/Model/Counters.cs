using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Количество различных объектов у пользователя.
/// См. описание http://vk.com/dev/fields
/// http://vk.com/dev/fields_groups
/// Раздел counters.
/// </summary>
[Serializable]
public class Counters
{
	/// <summary>
	/// Количество фотоальбомов.
	/// </summary>
	[JsonPropertyName("albums")]
	public int? Albums { get; set; }

	/// <summary>
	/// Количество видеозаписей.
	/// </summary>
	[JsonPropertyName("videos")]
	public int? Videos { get; set; }

	/// <summary>
	/// Количество аудиозаписей.
	/// </summary>
	[JsonPropertyName("audios")]
	public int? Audios { get; set; }

	/// <summary>
	/// Количество фотографий.
	/// </summary>
	[JsonPropertyName("photos")]
	public int? Photos { get; set; }

	/// <summary>
	/// Количество заметок.
	/// </summary>
	[JsonPropertyName("notes")]
	public int? Notes { get; set; }

	/// <summary>
	/// Количество друзей.
	/// </summary>
	[JsonPropertyName("friends")]
	public int? Friends { get; set; }

	/// <summary>
	/// Количество сообществ.
	/// </summary>
	[JsonPropertyName("groups")]
	public int? Groups { get; set; }

	/// <summary>
	/// Количество друзей онлайн.
	/// </summary>
	[JsonPropertyName("online_friends")]
	public int? OnlineFriends { get; set; }

	/// <summary>
	/// Количество общих друзей.
	/// </summary>
	[JsonPropertyName("mutual_friends")]
	public int? MutualFriends { get; set; }

	/// <summary>
	/// Количество видеозаписей с пользователем.
	/// </summary>
	[JsonPropertyName("user_videos")]
	public int? UserVideos { get; set; }

	/// <summary>
	/// Количество подписчиков.
	/// </summary>
	[JsonPropertyName("followers")]
	public int? Followers { get; set; }

	/// <summary>
	/// Количество фотографий с пользователем.
	/// </summary>
	[JsonPropertyName("user_photos")]
	public int? UserPhotos { get; set; }

	/// <summary>
	/// Количество подписок (только пользователи).
	/// </summary>
	[JsonPropertyName("subscriptions")]
	public int? Subscriptions { get; set; }

	/// <summary>
	/// Количество тем обсуждений сообщества.
	/// </summary>
	[JsonPropertyName("topics")]
	public int? TopicsCount { get; set; }

	/// <summary>
	/// Количество документов.
	/// </summary>
	[JsonPropertyName("docs")]
	public int? DocumentsCount { get; set; }

	#region Поля, установленные экспериментально

	/// <summary>
	/// Количество публичных страниц, на которые подписан пользователь.
	/// </summary>
	[JsonPropertyName("pages")]
	public int? Pages { get; set; }

	#endregion

	#region Счетчики из метода https: //vk.com/dev/account.getCounters

	/// <summary>
	/// Количество сообщений
	/// </summary>
	[JsonPropertyName("messages")]
	public int? Messages { get; set; }

	/// <summary>
	/// Количество подарков
	/// </summary>
	[JsonPropertyName("gifts")]
	public int? Gifts { get; set; }

	/// <summary>
	/// Количество событий
	/// </summary>
	[JsonPropertyName("events")]
	public int? Events { get; set; }

	/// <summary>
	/// Количество уведомлений
	/// </summary>
	[JsonPropertyName("notifications")]
	public int? Notifications { get; set; }

	/// <summary>
	/// SDK.
	/// </summary>
	[JsonPropertyName("sdk")]
	public int? Sdk { get; set; }

	/// <summary>
	/// Запросов к приложению.
	/// </summary>
	[JsonPropertyName("app_requests")]
	public int? AppRequests { get; set; }

	#endregion
}