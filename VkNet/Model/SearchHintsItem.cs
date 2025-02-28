using System;
using System.Text.Json.Serialization;
using VkNet.Enums.Filters;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Элемент подсказки поиска
/// </summary>
[Serializable]
public class SearchHintsItem
{
	/// <summary>
	/// тип объекта
	/// </summary>
	[JsonPropertyName("type")]
	public SearchResultType? Type { get; set; }

	/// <summary>
	/// данные о сообществе.
	/// </summary>
	[JsonPropertyName("group")]
	public SearchGroup Group { get; set; }

	/// <summary>
	/// данные о профиле.
	/// </summary>
	[JsonPropertyName("profile")]
	public SearchProfile Profile { get; set; }

	/// <summary>
	/// тип объекта
	/// </summary>
	[JsonPropertyName("section")]
	[JsonConverter(converterType: typeof(SafetyEnumJsonConverter))]
	public SearchFilter Section { get; set; }

	/// <summary>
	/// описание объекта (для сообществ — тип и число участников, например, Group,
	/// 269,136 members,
	/// для профилей друзей или пользователями, которые не являются возможными друзьями
	/// — название университета или город,
	/// для профиля текущего пользователя — That's you, для профилей возможных друзей —
	/// N mutual friends).
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// поле возвращается, если объект был найден в глобальном поиске, всегда содержит
	/// 1.
	/// </summary>
	[JsonPropertyName("global")]
	public bool? Global { get; set; }
}