using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о сообществе (группе).
/// См. описание http://vk.com/dev/fields_groups
/// </summary>
[Serializable]
public class GroupInfo
{
	#region Стандартные поля

	/// <summary>
	/// Название сообщества.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Описание сообщества.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Gets or sets the address.
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Место, указанное в информации о сообществе.
	/// </summary>
	[JsonPropertyName("place")]
	public Place Place { get; set; }

	/// <summary>
	/// Стена.
	/// </summary>
	[JsonPropertyName("wall")]
	public ContentAccess? Wall { get; set; }

	/// <summary>
	/// Фотографии.
	/// </summary>
	[JsonPropertyName("photos")]
	public ContentAccess? Photos { get; set; }

	/// <summary>
	/// Видеозаписи.
	/// </summary>
	[JsonPropertyName("video")]
	public ContentAccess? Video { get; set; }

	/// <summary>
	/// Аудиозаписи.
	/// </summary>
	[JsonPropertyName("audio")]
	public ContentAccess? Audio { get; set; }

	/// <summary>
	/// Документы.
	/// </summary>
	[JsonPropertyName("docs")]
	public ContentAccess? Docs { get; set; }

	/// <summary>
	/// Обсуждения.
	/// </summary>
	[JsonPropertyName("topics")]
	public ContentAccess? Topics { get; set; }

	/// <summary>
	/// Материалы.
	/// </summary>
	[JsonPropertyName("wiki")]
	public ContentAccess? Wiki { get; set; }

	/// <summary>
	/// Тип группы.
	/// </summary>
	[JsonPropertyName("access")]
	public GroupPublicity? Access { get; set; }

	/// <summary>
	/// Тематика сообщества.
	/// </summary>
	[JsonPropertyName("subject")]
	public GroupSubjects? Subject { get; set; }

	/// <summary>
	/// Адрес сайта, который будет указан в информации о группе
	/// </summary>
	[JsonPropertyName("website")]
	public string Website { get; set; }

	/// <summary>
	/// Контакты: (доступно только для публичных страниц).
	/// </summary>
	[JsonPropertyName("contacts")]
	public bool? Contacts { get; set; }

	/// <summary>
	/// Места: (доступно только для публичных страниц)
	/// </summary>
	[JsonPropertyName("places")]
	public bool? Places { get; set; }

	/// <summary>
	/// События: (доступно только для публичных страниц).
	/// </summary>
	[JsonPropertyName("events")]
	public bool? Events { get; set; }

	/// <summary>
	/// Ссылки: (доступно только для публичных страниц).
	/// </summary>
	[JsonPropertyName("links")]
	public bool? Links { get; set; }

	/// <summary>
	/// Дата основания компании, организации,
	/// которой посвящена публичная страница в виде строки формата <c>"dd.mm.YYYY"</c>.
	/// </summary>
	[JsonPropertyName("public_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? PublicDate { get; set; }

	/// <summary>
	/// Подкатегория публичной станицы.
	/// </summary>
	[JsonPropertyName("public_subcategory")]
	public ulong? PublicSubcategory { get; set; }

	/// <summary>
	/// Категория публичной страницы.
	/// </summary>
	[JsonPropertyName("public_category")]
	public ulong? PublicCategory { get; set; }

	/// <summary>
	/// Идентификатор группы, которая является организатором события (только для
	/// событий).
	/// </summary>
	[JsonPropertyName("event_group_id")]
	public ulong? EventGroupId { get; set; }

	/// <summary>
	/// Дата окончания события.
	/// </summary>
	[JsonPropertyName("event_finish_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? EventFinishDate { get; set; }

	/// <summary>
	/// Дата начала события.
	/// </summary>
	[JsonPropertyName("event_start_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? EventStartDate { get; set; }

	/// <summary>
	/// Адрес rss для импорта новостей
	/// (доступен только группам, получившим соответствуюшее разрешение,
	/// обратитесь в http://vk.com/support для получения разрешения).
	/// </summary>
	[JsonPropertyName("rss")]
	public string Rss { get; set; }

	/// <summary>
	/// Номер телефона сообщества.
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }

	/// <summary>
	/// Электронный адрес сообщества.
	/// </summary>
	[JsonPropertyName("email")]
	public string Email { get; set; }

	/// <summary>
	/// Короткое имя сообщества.
	/// </summary>
	[JsonPropertyName("screen_name")]
	public string ScreenName { get; set; }

	#endregion

	/// <summary>
	/// Список тематик
	/// </summary>
	[UsedImplicitly]
	public Dictionary<int, string> Subjects { get; } = new()
	{
		{
			1, "Авто/мото"
		},
		{
			2, "Активный отдых"
		},
		{
			3, "Бизнес"
		},
		{
			4, "Домашние животные"
		},
		{
			5, "Здоровье"
		},
		{
			6, "Знакомство и общение"
		},
		{
			7, "Игры"
		},
		{
			8, "ИТ (компьютеры и софт)"
		},
		{
			9, "Кино"
		},
		{
			10, "Красота и мода"
		},
		{
			11, "Кулинария"
		},
		{
			12, "Культура и искусство"
		},
		{
			13, "Литература"
		},
		{
			14, "Мобильная связь и интернет"
		},
		{
			15, "Музыка"
		},
		{
			16, "Наука и техника"
		},
		{
			17, "Недвижимость"
		},
		{
			18, "Новости и СМИ"
		},
		{
			19, "Безопасность"
		},
		{
			20, "Образование"
		},
		{
			21, "Обустройство и ремонт"
		},
		{
			22, "Политика"
		},
		{
			23, "Продукты питания"
		},
		{
			24, "Промышленность"
		},
		{
			25, "Путешествия"
		},
		{
			26, "Работа"
		},
		{
			27, "Развлечения"
		},
		{
			28, "Религия"
		},
		{
			29, "Дом и семья"
		},
		{
			30, "Спорт"
		},
		{
			31, "Страхование"
		},
		{
			32, "Телевидение"
		},
		{
			33, "Товары и услуги"
		},
		{
			34, "Увлечения и хобби"
		},
		{
			35, "Финансы"
		},
		{
			36, "Фото"
		},
		{
			37, "Эзотерика"
		},
		{
			38, "Электроника и бытовая техника"
		},
		{
			39, "Эротика"
		},
		{
			40, "Юмор"
		},
		{
			41, "Общество, гуманитарные науки"
		},
		{
			42, "Дизайн и графика"
		}
	};
}