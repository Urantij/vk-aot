using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса Video.GetCatalog
/// </summary>
[Serializable]
public class VideoGetCatalogParams
{
	/// <summary>
	/// Число блоков каталога, информацию о которых необходимо вернуть.
	/// Обратите внимание, параметр распространяется только на блоки other.
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	/// <summary>
	/// Число видеозаписей в каждом блоке.
	/// </summary>
	[JsonPropertyName("items_count")]
	public long? ItemsCount { get; set; }

	/// <summary>
	/// Параметр для получения следующей страницы результатов.
	/// Значение, необходимое для передачи в этом параметре, возвращается в поле ответа
	/// next.
	/// </summary>
	[JsonPropertyName("from")]
	public string From { get; set; }

	/// <summary>
	/// 1 — в ответе будут возвращены дополнительные поля profiles и groups,
	/// содержащие информацию о пользователях и сообществах.
	/// По умолчанию: 0.
	/// </summary>
	[JsonPropertyName("extended")]
	public bool? Extended { get; set; }

	/// <summary>
	/// id блоков, которые необходимо вернуть в ответе.
	/// </summary>
	[JsonPropertyName("filters")]
	public VideoCatalogFilters? Filters { get; set; }
}