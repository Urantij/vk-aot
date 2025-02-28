using System;
using System.Text.Json.Serialization;
using VkNet.Enums.Filters;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса для приложений
/// </summary>
[Serializable]
public class AppGetCatalogParams
{
	/// <summary>
	/// Способ сортировки приложений
	/// </summary>
	[JsonPropertyName("sort")]
	public AppSort? Sort { get; set; }

	/// <summary>
	/// Смещение, необходимое для выборки определенного подмножества приложений.
	/// </summary>
	[JsonPropertyName("offset")]
	public uint Offset { get; set; }

	/// <summary>
	/// Количество приложений, информацию о которых необходимо вернуть.
	/// </summary>
	[JsonPropertyName("count")]
	public uint Count { get; set; }

	/// <summary>
	/// Платформа для которой необходимо вернуть приложения, принимает значения: ios,
	/// android, winphone, web. По умолчанию
	/// используется web.
	/// </summary>
	[JsonPropertyName("platform")]
	public AppPlatforms? Platform { get; set; }

	/// <summary>
	/// Позволяет получить дополнительные поля: screenshots, MAU (количество уникальных
	/// посетителей в месяц),
	/// catalog_position, international (отображается ли приложение в каталоге у
	/// иностранных пользователей).
	/// По умолчанию возвращает только основные поля приложений. Если указан extended –
	/// count не должен быть больше 100.
	/// </summary>
	[JsonPropertyName("extended")]
	public bool Extended { get; set; }

	/// <summary>
	/// <c> true </c> – возвращает список друзей, установивших это приложение.
	/// (Данный параметр работает только, если пользователь передал валидный
	/// access_token)
	/// <c> false </c> – не возвращать список друзей, по умолчанию.
	/// </summary>
	[JsonPropertyName("return_friends")]
	public bool ReturnFriends { get; set; }

	/// <summary>
	/// Список дополнительных полей, которые необходимо вернуть для профилей
	/// пользователей.
	/// </summary>
	[JsonPropertyName("fields")]
	public UsersFields Fields { get; set; }

	/// <summary>
	/// Падеж для склонения имени и фамилии пользователей.
	/// </summary>
	[JsonPropertyName("name_case")]
	public NameCase? NameCase { get; set; }

	/// <summary>
	/// Поисковая строка для поиска по каталогу приложений.
	/// </summary>
	[JsonPropertyName("q")]
	public string Query { get; set; }

	/// <summary>
	/// Идентификатор жанра.
	/// </summary>
	[JsonPropertyName("genre_id")]
	public uint? GenreId { get; set; }

	/// <summary>
	/// Фильтр.
	/// </summary>
	[JsonPropertyName("filter")]
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	public AppFilter Filter { get; set; }
}