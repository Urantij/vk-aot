using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о сообществе (группе).
/// См. описание http://vk.com/dev/fields_groups
/// </summary>
[DebuggerDisplay("[{Id}] {Name}")]
[Serializable]
[JsonConverter(typeof(GroupJsonConverter))]
public class Group
{
	/// <summary>
	/// Конструктор
	/// </summary>
	public Group() => Type = new();

	[JsonPropertyName("finish_date")]
	private DateTime? FinishDate
	{
		get => EndDate;
		set => EndDate = value;
	}

	[JsonPropertyName("gid")]
	private long Gid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("group_id")]
	private long GroupId
	{
		get => Id;
		set => Id = value;
	}

	#region Стандартные поля

	/// <summary>
	/// Идентификатор сообщества.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название сообщества.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// Короткий адрес страницы сообщества, например, <c>apiclub</c>. Если он не назначен, то
	/// <c>'club'+gid</c>, например, <c>club35828305</c>.
	/// </summary>
	[JsonPropertyName("screen_name")]
	public string ScreenName { get; set; }

	/// <summary>
	/// Публичность группы.
	/// </summary>
	[JsonPropertyName("is_closed")]
	public GroupPublicity? IsClosed { get; set; }

	/// <summary>
	/// Возвращается в случае, если сообщество удалено или заблокировано
	/// </summary>
	// TODO Какое тут дефолтное значение то?
	// [JsonProperty("deactivated", DefaultValueHandling = DefaultValueHandling.Populate)]
	[JsonPropertyName("deactivated")]
	public Deactivated? Deactivated { get; set; }

	/// <summary>
	/// Информация о том, является ли текущий пользователь руководителем сообщества.
	/// </summary>
	[JsonPropertyName("is_admin")]
	public bool IsAdmin { get; set; }

	/// <summary>
	/// Уровень административных полномочий текущего пользователя в сообществе
	/// (действительно, если <c>IsAdmin = true</c>).
	/// </summary>
	[JsonPropertyName("admin_level")]
	public AdminLevel? AdminLevel { get; set; }

	/// <summary>
	/// Информация о том, является ли текущий пользователь участником сообщества.
	/// </summary>
	[JsonPropertyName("is_member")]
	public bool? IsMember { get; set; }

	/// <summary>
	/// Идентификатор пользователя пригласившего в группу
	/// </summary>
	[JsonPropertyName("invited_by")]
	public long? InvitedBy { get; set; }

	/// <summary>
	/// Тип сообщества.
	/// </summary>
	[JsonPropertyName("type")]
	public GroupType? Type { get; set; }

	[JsonPropertyName("photo")]
	private Uri Photo
	{
		get => Photo50;
		set => Photo50 = value;
	}

	[JsonPropertyName("photo_medium")]
	private Uri PhotoMedium
	{
		get => Photo100;
		set => Photo100 = value;
	}

	/// <summary>
	/// <c>Uri</c> фотографии сообщества с размером 50x50px
	/// </summary>
	[JsonPropertyName("photo_50")]
	public Uri Photo50 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии сообщества с размером 100x100px
	/// </summary>
	[JsonPropertyName("photo_100")]
	public Uri Photo100 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии сообщества с размером 200x200px
	/// </summary>
	[JsonPropertyName("photo_200")]
	public Uri Photo200 { get; set; }

	/// <summary>
	/// <c>Uri</c> фотографии сообщества с наибольшим размером
	/// </summary>
	[JsonPropertyName("photo_big")]
	public Uri PhotoBig { get; set; }

	#endregion

	#region Опциональные поля

	/// <summary>
	/// Строка состояния публичной страницы. У групп возвращается строковое значение,
	/// открыта ли группа или нет,
	/// а у событий дата начала.
	/// </summary>
	[JsonPropertyName("activity")]
	public string Activity { get; set; }

	/// <summary>
	/// Возрастное ограничение
	/// </summary>
	[JsonPropertyName("age_limits")]
	public AgeLimit? AgeLimits { get; set; }

	/// <summary>
	/// Информация о забанненом (добавленном в черный список) пользователе сообщества.
	/// </summary>
	[JsonPropertyName("ban_info")]
	public BanInfo BanInfo { get; set; }

	/// <summary>
	/// Информация о том, может ли текущий пользователь создать тему обсуждения в
	/// группе.
	/// (<c> true </c>, если пользователь может создать обсуждение, <c> false </c> –
	/// если не может).
	/// </summary>
	[JsonPropertyName("can_create_topic")]
	public bool CanCreateTopic { get; set; }

	/// <summary>
	/// Информация о том, может ли текущий пользователь написать сообщение сообществу.
	/// </summary>
	[JsonPropertyName("can_message")]
	public bool CanMessage { get; set; }

	/// <summary>
	/// Информация о том, может ли текущий пользователь оставлять записи на стене
	/// сообщества (<c> true </c> - может,
	/// <c> false </c> - не может).
	/// </summary>
	[JsonPropertyName("can_post")]
	public bool CanPost { get; set; }

	/// <summary>
	/// Информация о том, разрешено видеть чужие записи на стене группы (<c> true </c>
	/// - разрешено, <c> false </c> - не
	/// разрешено).
	/// </summary>
	[JsonPropertyName("can_see_all_posts")]
	public bool CanSeeAllPosts { get; set; }

	/// <summary>
	/// Информация о том, может ли текущий пользователь загружать документы в группу (
	/// <c> true </c>, если пользователь может
	/// загружать документы, <c> false </c> – если не может).
	/// </summary>
	[JsonPropertyName("can_upload_documents")]
	public bool CanUploadDocuments { get; set; }

	/// <summary>
	/// Информация о том, может ли текущий пользователь загружать видеозаписи в группу.
	/// </summary>
	[JsonPropertyName("can_upload_video")]
	public bool CanUploadVideo { get; set; }

	/// <summary>
	/// Город.
	/// </summary>
	[JsonPropertyName("city")]
	public City City { get; set; }

	/// <summary>
	/// Информация из блока контактов публичной страницы.
	/// </summary>
	[JsonPropertyName("contacts")]
	public ReadOnlyCollection<Contact> Contacts { get; set; }

	/// <summary>
	/// Счетчики сообщества.
	/// </summary>
	[JsonPropertyName("counters")]
	public Counters Counters { get; set; }

	/// <summary>
	/// Идентификатор страны, указанной в информации о сообществе. Возвращается
	/// идентификатор страны, который можно
	/// использовать для
	/// получения ее названия с помощью метода <c>DatabaseCategory.GetCountriesById</c>
	/// </summary>
	[JsonPropertyName("country")]
	public Country Country { get; set; }

	/// <summary>
	/// Обложка сообщества
	/// </summary>
	[JsonPropertyName("cover")]
	public GroupCover Cover { get; set; }

	/// <summary>
	/// Текст описания сообщества.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Идентификатор закрепленного поста сообщества. Сам пост можно получить,
	/// используя <c>WallCategory.GetById</c>
	/// передав идентификатор в виде – <c>{group_id}_{post_id}</c>.
	/// </summary>
	[JsonPropertyName("fixed_post")]
	public long? FixedPost { get; set; }

	/// <summary>
	/// Содержит фото.
	/// </summary>
	[JsonPropertyName("has_photo")]
	public bool HasPhoto { get; set; }

	/// <summary>
	/// Возвращается 1, если пользователь является рекламодателем.
	/// </summary>
	[JsonPropertyName("is_advertiser")]
	public bool IsAdvertiser { get; set; }

	/// <summary>
	/// Возвращается 1, если сообщество находится в закладках у текущего пользователя.
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool IsFavorite { get; set; }

	/// <summary>
	/// Возвращается 1, если сообщество скрыто в новостях у текущего пользователя.
	/// </summary>
	[JsonPropertyName("is_hidden_from_feed")]
	public bool IsHiddenFromFeed { get; set; }

	/// <summary>
	/// Информация о том, разрешено ли сообществу отправлять сообщения текущему
	/// пользователю.
	/// </summary>
	[JsonPropertyName("is_messages_allowed")]
	public bool? IsMessagesAllowed { get; set; }

	/// <summary>
	/// Информация из блока ссылок сообщества.
	/// </summary>
	[JsonPropertyName("links")]
	public ReadOnlyCollection<ExternalLink> Links { get; set; }

	/// <summary>
	/// Идентификатор основного альбома сообщества.
	/// </summary>
	[JsonPropertyName("main_album_id")]
	public uint? MainAlbumId { get; set; }

	/// <summary>
	/// Информация о главной секции в сообществе
	/// </summary>
	[JsonPropertyName("main_section")]
	public MainSection? MainSection { get; set; }

	/// <summary>
	/// Информация о магазине
	/// </summary>
	[JsonPropertyName("market")]
	public GroupMarket Market { get; set; }

	/// <summary>
	/// Статус участника текущего пользователя.
	/// </summary>
	[JsonPropertyName("member_status")]
	public MemberStatus? MemberStatus { get; set; }

	/// <summary>
	/// Количество участников сообщества.
	/// </summary>
	[JsonPropertyName("members_count")]
	public int? MembersCount { get; set; }

	/// <summary>
	/// Место, указанное в информации о сообществе.
	/// </summary>
	[JsonPropertyName("place")]
	public Place Place { get; set; }

	/// <summary>
	/// Возвращается для публичных страниц. Текст описания для поля <c>start_date</c>.
	/// </summary>
	[JsonPropertyName("public_date_label")]
	public string PublicDateLabel { get; set; }

	/// <summary>
	/// Адрес сайта из поля «веб-сайт» в описании сообщества.
	/// </summary>
	[JsonPropertyName("site")]
	public string Site { get; set; }

	/// <summary>
	/// Время начала встречи (возвращаются только для встреч).
	/// </summary>
	[JsonPropertyName("start_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Объект аудиозаписи, установленной в статус (если аудиозапись транслируется в текущей момент).
	/// </summary>
	[JsonPropertyName("status_audio")]
	public Audio StatusAudio { get; set; }

	/// <summary>
	/// Время окончания встречи (возвращаются только для встреч).
	/// </summary>
	[JsonPropertyName("end_date")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Статус сообщества. Возвращается строка, содержащая текст статуса,
	/// расположенного на странице сообщества под его
	/// названием.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }

	/// <summary>
	/// Информация о том, есть ли у сообщества «огонёк».
	/// </summary>
	[JsonPropertyName("trending")]
	public bool Trending { get; set; }

	/// <summary>
	/// Возвращает информацию о том, является ли сообщество верифицированным.
	/// </summary>
	[JsonPropertyName("verified")]
	public bool Verified { get; set; }

	/// <summary>
	/// Название главной вики-страницы сообщества.
	/// </summary>
	[JsonPropertyName("wiki_page")]
	public string WikiPage { get; set; }

	/// <summary>
	/// Информация о ссылках на предпросмотр фотографий сообщества.
	/// </summary>
	[JsonPropertyName("photo_previews")]
	public Previews PhotoPreviews { get; set; }

	/// <summary>
	/// Стена
	/// </summary>
	[JsonPropertyName("wall")]
	public WallType? Wall { get; set; }

	#endregion
}