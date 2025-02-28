using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Результат метода fave.get
/// </summary>
[Serializable]
public class FaveGetObject
{
	/// <summary>
	/// Дата добавления объекта в закладки.
	/// </summary>
	[JsonPropertyName("added_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime AddedDate { get; set; }

	/// <summary>
	/// Является ли закладка просмотренной.
	/// </summary>
	[JsonPropertyName("seen")]
	public bool Seen { get; set; }

	/// <summary>
	/// Тип объекта, добавленного в закладки.
	/// </summary>
	[JsonPropertyName("type")]
	public FaveType? Type { get; set; }

	/// <summary>
	/// Массив меток объекта в списке закладок.
	/// </summary>
	[JsonPropertyName("tags")]
	public IEnumerable<FaveTag> Tags { get; set; }

	/// <summary>
	/// Запись со стены пользователя или сообщества.
	/// </summary>
	[JsonPropertyName("post")]
	public Post Post { get; set; }

	/// <summary>
	/// Видеозапись пользователя или группы.
	/// </summary>
	[JsonPropertyName("video")]
	public Video Video { get; set; }

	/// <summary>
	/// Информация о продукте.
	/// </summary>
	[JsonPropertyName("product")]
	public Market Product { get; set; }

	/// <summary>
	/// Статья
	/// </summary>
	[JsonPropertyName("article")]
	public Article Article { get; set; }

	/// <summary>
	/// Подкаст
	/// </summary>
	[JsonPropertyName("podcast")]
	public Podcast Podcast { get; set; }

	/// <summary>
	/// Ссылка на Web-страницу.	///  См. описание http://vk.com/dev/attachments_w
	/// </summary>
	[JsonPropertyName("link")]
	public Link Link { get; set; }
}