using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса на получение списка пользователей
/// </summary>
[Serializable]
public class GetUsersParams
{
	/// <summary>
	/// Идентификатор рекламной акции.
	/// </summary>
	[JsonPropertyName("offer_id")]
	public ulong OfferId { get; set; }

	/// <summary>
	/// Секретный ключ, доступный в интерфейсе редактирования рекламной акции.
	/// </summary>
	[JsonPropertyName("secret")]
	public string Secret { get; set; }

	/// <summary>
	/// Смещение необходимое для выборки определенного подмножества действий.
	/// </summary>
	[JsonPropertyName("offset")]
	public ulong Offset { get; set; }

	/// <summary>
	/// Количество действий, которые необходимо вернуть.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Тип действия
	/// </summary>
	[JsonPropertyName("status")]
	public GetUsersStatus Status { get; set; }

	/// <summary>
	/// 0 — сортировка в обратном хронологическом порядке;
	/// 1 — сортировка в прямом хронологическом порядке.
	/// </summary>
	[JsonPropertyName("reverse")]
	public bool Reverse { get; set; }
}