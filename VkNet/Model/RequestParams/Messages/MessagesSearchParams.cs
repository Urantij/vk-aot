using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса messages.search
/// </summary>
[Serializable]
public class MessagesSearchParams
{
	/// <summary>
	/// Подстрока, по которой будет производиться поиск.
	/// </summary>
	[JsonPropertyName("q")]
	public string Query { get; set; }

	/// <summary>
	/// Список дополнительных полей для пользователей и сообществ. список слов, разделенных через запятую
	/// </summary>
	[JsonPropertyName("fields")]
	[CanBeNull]
	public IEnumerable<string> Fields { get; set; }

	/// <summary>
	/// Фильтр по идентификатору назначения для поиска по отдельному диалогу
	/// </summary>
	[JsonPropertyName("peer_id")]
	public long? PeerId { get; set; }

	/// <summary>
	/// Дата в формате DDMMYYYY — если параметр задан, в ответе будут только сообщения,
	/// отправленные до указанной даты.
	/// </summary>
	[JsonPropertyName("date")]
	[DateTimeToStringFormat("ddMMyyyy")]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Количество символов, по которому нужно обрезать сообщение.
	/// Укажите 0, если Вы не хотите обрезать сообщение. (по умолчанию сообщения не
	/// обрезаются).
	/// </summary>
	[JsonPropertyName("preview_length")]
	public uint? PreviewLength { get; set; }

	/// <summary>
	/// Смещение, необходимое для выборки определенного подмножества сообщений из
	/// списка найденных.
	/// </summary>
	[JsonPropertyName("offset")]
	public uint? Offset { get; set; }

	/// <summary>
	/// Количество сообщений, которое необходимо получить.
	/// </summary>
	/// <remarks>
	/// По умолчанию 20.
	/// </remarks>
	[JsonPropertyName("count")]
	public uint? Count { get; set; }

	/// <summary>
	/// 1 — возвращать дополнительные поля для пользователей и сообществ. В ответе будет содержаться массив объектов бесед. флаг, может принимать значения 1 или 0
	/// </summary>
	[JsonPropertyName("extended")]
	public bool? Extended { get; set; }

	/// <summary>
	/// Идентификатор сообщества (для сообщений сообщества с ключом доступа пользователя). положительное число
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong? GroupId { get; set; }
}