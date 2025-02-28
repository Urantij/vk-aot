using System;
using System.Text.Json.Serialization;
using VkNet.Enums.Filters;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса Search.GetHints
/// </summary>
[Serializable]
public class SearchGetHintsParams
{
	/// <summary>
	/// текст запроса, результаты которого нужно получить
	/// </summary>
	[JsonPropertyName("q")]
	public string Query { get; set; }

	/// <summary>
	/// смещение для выборки определённого подмножества результатов.
	/// </summary>
	[JsonPropertyName("offset")]
	public uint Offset { get; set; }

	/// <summary>
	/// ограничение на количество возвращаемых результатов.
	/// </summary>
	[JsonPropertyName("limit")]
	public uint Limit { get; set; }

	/// <summary>
	/// Перечисленные через запятую типы данных, которые необходимо вернуть. По
	/// умолчанию возвращаются все.
	/// </summary>
	[JsonPropertyName("filters")]
	public SearchFilter Filters { get; set; }

	/// <summary>
	/// дополнительные поля профилей и сообществ для получения.
	/// </summary>
	[JsonPropertyName("fields")]
	public ProfileFields ProfileFields { get; set; }

	/// <summary>
	/// 1 — к результатам поиска добавляются результаты глобального поиска по всем
	/// пользователям и группам.
	/// </summary>
	[JsonPropertyName("search_global")]
	public bool SearchGlobal { get; set; } = true;
}