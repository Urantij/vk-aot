using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Новость
/// </summary>
[Serializable]
public class NewsSearchItem
{
	/// <summary>
	/// Локальный идентификатор записи (для конкретного владельца).
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор владельца стены, на которой размещена запись. Если стена
	/// принадлежит сообществу, то данный параметр
	/// равен -gid (идентификатор сообщества со знаком минус).
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long OwnerId { get; set; }

	/// <summary>
	/// Идентификатор автора записи;.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Время публикации записи в формате unixtime.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Текст записи.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Содержит информацию о количестве комментариев к записи.
	/// </summary>
	[JsonPropertyName("comments")]
	public Comments Comments { get; set; }

	/// <summary>
	/// Содержит информацию о числе людей, которым понравилась данная запись.
	/// </summary>
	[JsonPropertyName("likes")]
	public Likes Likes { get; set; }

	/// <summary>
	/// Содержит информацию о количестве репостов записи.
	/// </summary>
	[JsonPropertyName("reposts")]
	public Reposts Reposts { get; set; }

	/// <summary>
	/// Находится в записях со стен и содержит массив объектов, которые прикреплены к
	/// текущей новости (фотография, ссылка и
	/// т.п.). Более подробная информация представлена на странице Описание поля
	/// attachments.
	/// </summary>
	[JsonPropertyName("attachments")]
	// [JsonConverter(typeof(AttachmentJsonConverter))]
	public ReadOnlyCollection<Attachment> Attachments { get; set; }

	/// <summary>
	/// Находится в записях со стен, в которых имеется информация о местоположении.
	/// </summary>
	[JsonPropertyName("geo")]
	public Geo Geo { get; set; }

	/// <summary>
	/// Идентификатор владельца записи.
	/// </summary>
	[JsonPropertyName("signer_id")]
	public long? SignerId { get; set; }

	/// <summary>
	/// Тип записи
	/// </summary>
	[JsonPropertyName("post_type")]
	public PostType? PostType { get; set; }

	/// <summary>
	/// Идентификатор записи при PostType == reply
	/// </summary>
	[JsonPropertyName("post_id")]
	public int? PostId { get; set; } //Будет иметь значение null, кроме случаев при "post_type": "reply"

	/// <summary>
	/// Идентификатор на следующую пачку записей
	/// </summary>
	[JsonPropertyName("next_from")]
	public string NextFrom { get; set; }

	/// <summary>
	/// массив profiles
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// массив groups
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }

	/// <summary>
	/// Информация информацию о том, каким образом (через интерфейс сайта, виджет и
	/// т.п.) была создана запись на стене.
	/// </summary>
	[JsonPropertyName("post_source")]
	public PostSource PostSource { get; set; }

	/// <summary>
	/// В закладках
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool IsFavorite { get; set; }

	/// <summary>
	/// Помечено как реклама
	/// </summary>
	[JsonPropertyName("marked_as_ads")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public long? MarkedAsAds { get; set; }

	/// <summary>
	/// Просмотры
	/// </summary>
	[JsonPropertyName("views")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public Views Views { get; set; }
}