using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Приложение.
/// </summary>
[Serializable]
public class App
{
	/// <summary>
	/// Идентификатор приложения.
	/// </summary>
	[JsonPropertyName("id")]
	public ulong Id { get; set; }

	/// <summary>
	/// Название приложения.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Uri-адрес обложки приложения шириной 278px.
	/// </summary>
	[JsonPropertyName("icon_278")]
	public string Icon278 { get; set; }

	/// <summary>
	/// Uri-адрес обложки приложения шириной 139px.
	/// </summary>
	[JsonPropertyName("icon_139")]
	public string Icon139 { get; set; }

	/// <summary>
	/// Uri-адрес обложки приложения шириной 150px.
	/// </summary>
	[JsonPropertyName("icon_150")]
	public string Icon150 { get; set; }

	/// <summary>
	/// Uri-адрес обложки приложения шириной 75px.
	/// </summary>
	[JsonPropertyName("icon_75")]
	public string Icon75 { get; set; }

	/// <summary>
	/// Uri-адрес баннера шириной 560px.
	/// </summary>
	[JsonPropertyName("banner_560")]
	public string Banner560 { get; set; }

	/// <summary>
	/// Uri-адрес баннера шириной 1120px.
	/// </summary>
	[JsonPropertyName("banner_1120")]
	public string Banner1120 { get; set; }

	/// <summary>
	/// Тип приложения:.
	/// </summary>
	[JsonPropertyName("type")]
	public AppType? Type { get; set; }

	/// <summary>
	/// Категория приложения.
	/// </summary>
	[JsonPropertyName("section")]
	public string Section { get; set; }

	/// <summary>
	/// Адрес страницы автора приложения.
	/// </summary>
	[JsonPropertyName("author_url")]
	public string AuthorUrl { get; set; }

	/// <summary>
	/// Идентификатор автора приложения.
	/// </summary>
	[JsonPropertyName("author_id")]
	public ulong? AuthorId { get; set; }

	/// <summary>
	/// Идентификатор официальной группы приложения.
	/// </summary>
	[JsonPropertyName("author_group")]
	public ulong? AuthorGroup { get; set; }

	/// <summary>
	/// Количество участников приложения.
	/// </summary>
	[JsonPropertyName("members_count")]
	public ulong MembersCount { get; set; }

	/// <summary>
	/// Дата размещения.
	/// </summary>
	[JsonPropertyName("published_date")]
	public string PublishedDate { get; set; }

	/// <summary>
	/// Позиция в каталоге.
	/// </summary>
	[JsonPropertyName("catalog_position")]
	public ulong? CatalogPosition { get; set; }

	/// <summary>
	/// Является ли приложение мультиязычным (<c> true </c>).
	/// </summary>7
	[JsonPropertyName("international")]
	public bool International { get; set; }

	/// <summary>
	/// Тип турнирной таблицы (0 - не поддерживается, 1 - по уровню, 2 - по очкам).
	/// </summary>
	[JsonPropertyName("leaderboard_type")]
	public LeaderboardTypes LeaderBoardType { get; set; }

	/// <summary>
	/// Идентификатор жанра.
	/// </summary>
	[JsonPropertyName("genre_id")]
	public int? GenreId { get; set; }

	/// <summary>
	/// Название жанра.
	/// </summary>
	[JsonPropertyName("genre")]
	public string Genre { get; set; }

	/// <summary>
	/// Идентификатор приложения в магазине приложений.
	/// </summary>
	[JsonPropertyName("platform_id")]
	public int? PlatformId { get; set; }

	/// <summary>
	/// Доступно ли приложение в мобильном каталоге.
	/// </summary>
	[JsonPropertyName("is_in_catalog")]
	public bool? IsInCatalog { get; set; }

	/// <summary>
	/// список идентификаторов друзей текущего пользователя, которые установили
	/// приложение
	/// (если был передан параметр return_friends = 1.
	/// </summary>
	[JsonPropertyName("friends")]
	public ReadOnlyCollection<long> Friends { get; set; }

	/// <summary>
	/// 1, если приложение установлено у текущего пользователя.
	/// </summary>
	[JsonPropertyName("installed")]
	public bool? Installed { get; set; }

	/// <summary>
	/// 1, если приложение — html5 игра.
	/// </summary>
	[JsonPropertyName("is_html_5_app")]
	[Obsolete("5.85 В объекте приложения больше не приходит поле is_html5_app. Смотрите поле type", false)]
	public bool IsHtml5App { get; set; }

	/// <summary>
	/// Поддерживаемая ориентация экрана.
	/// </summary>
	[JsonPropertyName("screen_orientation")]
	public ScreenOrientation? ScreenOrientation { get; set; }

	/// <summary>
	/// Описывает, как отображаются элементы управления для игр в вебвью в нативных клиентах
	/// </summary>
	[JsonPropertyName("mobile_controls_type")]
	public MobileControlsType MobileControlsType { get; set; }

	/// <summary>
	/// Описывает, как отображаются элементы управления для игр в вебвью в нативных клиентах
	/// </summary>
	[JsonPropertyName("mobile_view_support_type")]
	public MobileViewSupportType MobileViewSupportType { get; set; }

	#region Опциональные поля

	/// <summary>
	/// Описание.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Поддомен приложения (или строка idXXXXXXX, если поддомен не задан).
	/// </summary>
	[JsonPropertyName("screen_name")]
	public string ScreenName { get; set; }

	/// <summary>
	/// Uri-адрес обложки приложения шириной 16px.
	/// </summary>
	[JsonPropertyName("icon_16")]
	public string Icon16 { get; set; }

	/// <summary>
	/// Uri-адреса изображений-скриншотов из приложения.
	/// </summary>
	[JsonPropertyName("screenshots")]
	public IEnumerable<Photo> Screenshots { get; set; }

	/// <summary>
	/// 1, если у пользователя включены уведомления из этого приложения.
	/// </summary>
	[JsonPropertyName("push_enabled")]
	public bool? PushEnabled { get; set; }

	#endregion
}