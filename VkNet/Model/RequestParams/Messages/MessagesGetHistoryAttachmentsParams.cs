using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода messages.getHistoryAttachments
/// </summary>
[Serializable]
public class MessagesGetHistoryAttachmentsParams
{
	/// <summary>
	/// Идентификатор назначения. Для групповой беседы:
	/// 2000000000   id беседы.
	/// Для email:
	/// id беседы &lt; -2000000000
	/// Для сообщества:
	/// -id сообщества.
	/// целое число, обязательный параметр.
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long PeerId { get; set; }

	/// <summary>
	/// Тип материалов, который необходимо вернуть.
	/// Доступные значения:
	/// photo — фотографии;
	/// video — видеозаписи;
	/// audio — аудиозаписи;
	/// doc — документы;
	/// link — ссылки;
	/// market — товары;
	/// wall — записи;
	/// share — ссылки, товары и записи.
	/// Обратите внимание — существует ограничение по дате отправки вложений. Так, для
	/// получения доступны вложения типов
	/// photo,video,audio,doc , отправленные не ранее 25.03.2013, link — не ранее
	/// 20.05.13, market,wall — 01.02.2016.
	/// строка, по умолчанию photo.
	/// </summary>
	[JsonPropertyName("media_type")]
	public MediaType? MediaType { get; set; }

	/// <summary>
	/// Смещение, необходимое для выборки определенного подмножества объектов. строка.
	/// </summary>
	[JsonPropertyName("start_from")]
	public string StartFrom { get; set; }

	/// <summary>
	/// Список слов, разделенных через запятую.
	/// </summary>
	[JsonPropertyName("fields")]
	public IEnumerable<string> Fields { get; set; }

	/// <summary>
	/// Количество объектов, которое необходимо получить (но не более 200).
	/// положительное число, максимальное значение 200,
	/// по умолчанию 30.
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// Параметр, указывающий нужно ли возвращать ли доступные размеры фотографии в
	/// специальном формате. флаг, может
	/// принимать значения 1 или 0.
	/// </summary>
	[JsonPropertyName("photo_sizes")]
	public bool? PhotoSizes { get; set; }

	/// <summary>
	/// Идентификатор сообщества (для сообщений сообщества с ключом доступа пользователя). положительное число
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }
}