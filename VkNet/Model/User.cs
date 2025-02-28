using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Enums.StringEnums;
using VkNet.Utils.JsonConverter;

// ReSharper disable UnusedAutoPropertyAccessor.Global

// ReSharper disable MemberCanBePrivate.Global

namespace VkNet.Model;

/// <summary>
/// Информация о пользователе.
/// См. описание https://vk.com/dev/objects/user
/// </summary>
[DebuggerDisplay("[{Id}] {FirstName} {LastName}")]
[Serializable]
[JsonConverter(typeof(UserJsonConverter))]
public class User
{
	#region Базовые поля

	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Имя пользователя.
	/// </summary>
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; }

	[JsonPropertyName("name")]
	private string Name
	{
		get => FirstName;
		set => FirstName = value;
	}

	/// <summary>
	/// Фамилия пользователя.
	/// </summary>
	[JsonPropertyName("last_name")]
	public string LastName { get; set; }

	/// <summary>
	/// Возвращается при вызове без access_token, если пользователь установил настройку
	/// «Кому в интернете видна моя
	/// страница» — «Только пользователям ВКонтакте».
	/// Обратите внимание, в этом случае дополнительные поля fields не возвращаются.
	/// </summary>
	[JsonPropertyName("hidden")]
	public bool Hidden { get; set; }

	/// <summary>
	/// Скрыт ли профиль пользователя настройками приватности.
	/// </summary>
	/// <remarks>
	/// Начиная с версии 5.89 обязательное поле
	/// </remarks>
	[JsonPropertyName("is_closed")]
	public bool? IsClosed { get; set; }

	/// <summary>
	/// Может ли текущий пользователь видеть профиль при is_closed = 1 (например, если он есть в друзьях).
	/// </summary>
	/// <remarks>
	/// Начиная с версии 5.89 обязательное поле
	/// </remarks>
	[JsonPropertyName("can_access_closed")]
	public bool? CanAccessClosed { get; set; }

	#endregion

	#region Опциональные поля

	/// <summary>
	/// Причина блокирования аккаунта
	/// </summary>
	// TODO Какое тут дефолтное значение то?
	// [JsonProperty("deactivated", DefaultValueHandling = DefaultValueHandling.Populate)]
	[JsonPropertyName("deactivated")]
	public Deactivated? Deactivated { get; set; }

	/// <summary>
	/// Информация пользователя о себе.
	/// </summary>
	[JsonPropertyName("about")]
	public string About { get; set; }

	/// <summary>
	/// Информация пользователя о себе.
	/// </summary>
	[JsonPropertyName("twitter")]
	public string Twitter { get; set; }

	/// <summary>
	/// Чем занимается пользователь.
	/// </summary>
	[JsonPropertyName("activities")]
	public string Activities { get; set; }

	/// <summary>
	/// Дата рождения пользователя. Возвращается в формате DD.MM.YYYY или DD.MM (если
	/// год рождения скрыт).
	/// Если дата рождения скрыта целиком, поле отсутствует в ответе.
	/// </summary>
	[JsonPropertyName("bdate")]
	public string BirthDate { get; set; }

	/// <summary>
	/// Возвращается 1, если текущий пользователь находится в черном списке у
	/// запрашиваемого пользователя.
	/// </summary>
	[JsonPropertyName("blacklisted")]
	public bool Blacklisted { get; set; }

	/// <summary>
	/// Возвращается 1, если запрашиваемый пользователь находится в черном списке у
	/// текущего пользователя.
	/// </summary>
	[JsonPropertyName("blacklisted_by_me")]
	public bool BlacklistedByMe { get; set; }

	/// <summary>
	/// Любимые книги пользователя.
	/// </summary>
	[JsonPropertyName("books")]
	public string Books { get; set; }

	/// <summary>
	/// Признак разрешено ли оставлять записи на стене у пользователя.
	/// </summary>
	[JsonPropertyName("can_post")]
	public bool CanPost { get; set; }

	/// <summary>
	/// Признак разрешено ли видеть чужие записи на стене пользователя.
	/// </summary>
	[JsonPropertyName("can_see_all_posts")]
	public bool CanSeeAllPosts { get; set; }

	/// <summary>
	/// Признак разрешено ли видеть чужие аудиозаписи на стене пользователя.
	/// </summary>
	[JsonPropertyName("can_see_audio")]
	public bool CanSeeAudio { get; set; }

	/// <summary>
	/// Информация о том, будет ли отправлено уведомление пользователю о заявке в
	/// друзья.
	/// </summary>
	[JsonPropertyName("can_send_friend_request")]
	public bool CanSendFriendRequest { get; set; }

	/// <summary>
	/// Признак разрешено ли написание личных сообщений данному пользователю.
	/// </summary>
	[JsonPropertyName("can_write_private_message")]
	public bool CanWritePrivateMessage { get; set; }

	/// <summary>
	/// Информация о карьере пользователя.
	/// </summary>
	[JsonPropertyName("career")]
	public ReadOnlyCollection<Career> Career { get; set; }

	/// <summary>
	/// Идентификатор города, указанного на странице пользователя в разделе «Контакты».
	/// Если город не указан, или основная информация страницы скрыта настройками
	/// приватности, то 0.
	/// </summary>
	[JsonPropertyName("city")]
	public City City { get; set; }

	/// <summary>
	/// Общее количество друзей с текущим пользователем.
	/// </summary>
	[JsonPropertyName("common_count")]
	public int? CommonCount { get; set; }

	/// <summary>
	/// Данные о подключенных сервисах пользователя, таких как: skype, facebook,
	/// twitter, instagram.
	/// </summary>
	[JsonPropertyName("connections")]
	public Connections Connections { get; set; }

	/// <summary>
	/// Информация о телефонных номерах пользователя.
	/// </summary>
	[JsonPropertyName("contacts")]
	public Contacts Contacts { get; set; }

	/// <summary>
	/// Различные счетчики пользователя.
	/// </summary>
	[JsonPropertyName("counters")]
	public Counters Counters { get; set; }

	/// <summary>
	/// Идентификатор страны, указанной на странице пользователя в разделе «Контакты».
	/// Если страна не указана или основная информация страницы скрыта настройками
	/// приватности, то 0.
	/// </summary>
	[JsonPropertyName("country")]
	public Country Country { get; set; }

	/// <summary>
	/// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная
	/// фотографии пользователя.
	/// </summary>
	[JsonPropertyName("crop_photo")]
	public CropPhoto CropPhoto { get; set; }

	/// <summary>
	/// Короткий адрес страницы пользователя. Возвращается строка, содержащая короткий
	/// адрес страницы (возвращается только
	/// сам поддомен, например, andrew). Если он не назначен, то "id"+uid, например,
	/// id35828305.
	/// </summary>
	[JsonPropertyName("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// Сведения об образовании пользователя.
	/// </summary>
	[JsonPropertyName("education")]
	public Education Education { get; set; }

	/// <summary>
	/// Внешние сервисы, в которые настроен экспорт из ВК.
	/// </summary>
	[JsonPropertyName("exports")]
	public Exports Exports { get; set; }

	/// <summary>
	/// Имя в именительном падеже
	/// </summary>
	[JsonPropertyName("first_name_nom")]
	public string FirstNameNom { get; set; }

	/// <summary>
	/// Имя в родительном падеже
	/// </summary>
	[JsonPropertyName("first_name_gen")]
	public string FirstNameGen { get; set; }

	/// <summary>
	/// Имя в дательном падеже
	/// </summary>
	[JsonPropertyName("first_name_dat")]
	public string FirstNameDat { get; set; }

	/// <summary>
	/// Имя в винительном падеже
	/// </summary>
	[JsonPropertyName("first_name_acc")]
	public string FirstNameAcc { get; set; }

	/// <summary>
	/// Имя в творительном падеже
	/// </summary>
	[JsonPropertyName("first_name_ins")]
	public string FirstNameIns { get; set; }

	/// <summary>
	/// Имя в предложном падеже
	/// </summary>
	[JsonPropertyName("first_name_abl")]
	public string FirstNameAbl { get; set; }

	/// <summary>
	/// Количество подписчиков пользователя.
	/// </summary>
	[JsonPropertyName("followers_count")]
	public long? FollowersCount { get; set; }

	/// <summary>
	/// Состояние дружбы с пользователями.
	/// </summary>
	[JsonPropertyName("friend_status")]
	public FriendStatus? FriendStatus { get; set; }

	/// <summary>
	/// Любимые игры пользователя.
	/// </summary>
	[JsonPropertyName("games")]
	public string Games { get; set; }

	/// <summary>
	/// Информация о том, известен ли номер мобильного телефона пользователя (true -
	/// известен, false - не известен).
	/// </summary>
	[JsonPropertyName("has_mobile")]
	public bool? HasMobile { get; set; }

	/// <summary>
	/// Возвращается 1, если текущий пользователь установил фотографию для профиля.
	/// </summary>
	[JsonPropertyName("has_photo")]
	public bool? HasPhoto { get; set; }

	/// <summary>
	/// Родной город пользователя.
	/// </summary>
	[JsonPropertyName("home_town")]
	public string HomeTown { get; set; }

	/// <summary>
	/// Интересы пользователя.
	/// </summary>
	[JsonPropertyName("interests")]
	public string Interests { get; set; }

	/// <summary>
	/// Возвращается 1, если пользователь находится в закладках у текущего
	/// пользователя.
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool IsFavorite { get; set; }

	/// <summary>
	/// 1 – пользователь друг, 2 – пользователь не в друзьях.
	/// </summary>
	[JsonPropertyName("is_friend")]
	public bool? IsFriend { get; set; }

	/// <summary>
	/// Возвращается 1, если пользователь скрыт в новостях у текущего пользователя.
	/// </summary>
	[JsonPropertyName("is_hidden_from_feed")]
	public bool IsHiddenFromFeed { get; set; }

	/// <summary>
	/// Фамилия в именительном падеже
	/// </summary>
	[JsonPropertyName("last_name_nom")]
	public string LastNameNom { get; set; }

	/// <summary>
	/// Фамилия в родительном падеже
	/// </summary>
	[JsonPropertyName("last_name_gen")]
	public string LastNameGen { get; set; }

	/// <summary>
	/// Фамилия в дательном падеже
	/// </summary>
	[JsonPropertyName("last_name_dat")]
	public string LastNameDat { get; set; }

	/// <summary>
	/// Фамилия в винительном падеже
	/// </summary>
	[JsonPropertyName("last_name_acc")]
	public string LastNameAcc { get; set; }

	/// <summary>
	/// Фамилия в творительном падеже
	/// </summary>
	[JsonPropertyName("last_name_ins")]
	public string LastNameIns { get; set; }

	/// <summary>
	/// Фамилия в предложном падеже
	/// </summary>
	[JsonPropertyName("last_name_abl")]
	public string LastNameAbl { get; set; }

	/// <summary>
	/// Время последнего посещения сайта.
	/// </summary>
	[JsonPropertyName("last_seen")]
	public LastSeen LastSeen { get; set; }

	/// <summary>
	/// Идентификаторы списков друзей, в которых состоит пользователь. Поле доступно
	/// только для метода
	/// FriendsCategory.Get. Получить информацию об идентификаторах и названиях списков
	/// друзей можно с
	/// помощью метода FriendsCategory.GetLists. Если пользователь не состоит ни в
	/// одном списке друзей, данное
	/// поле принимает значение null.
	/// </summary>
	/// <remarks>
	/// поле lists
	/// </remarks>
	[JsonPropertyName("lists")]
	public ReadOnlyCollection<long> FriendLists { get; set; }

	/// <summary>
	/// Девичья фамилия (только для женского пола)
	/// </summary>
	[JsonPropertyName("maiden_name")]
	public string MaidenName { get; set; }

	/// <summary>
	/// Информация о военной службе пользователя.
	/// </summary>
	[JsonPropertyName("military")]
	public Military[] Military { get; set; }

	/// <summary>
	/// Любимые фильмы пользователя.
	/// </summary>
	[JsonPropertyName("movies")]
	public string Movies { get; set; }

	/// <summary>
	/// Любимая музыка пользователя.
	/// </summary>
	[JsonPropertyName("music")]
	public string Music { get; set; }

	/// <summary>
	/// Прозвище (ник) пользователя.
	/// </summary>
	[JsonPropertyName("nickname")]
	public string Nickname { get; set; }

	/// <summary>
	/// Информация о текущем роде занятия пользователя.
	/// </summary>
	[JsonPropertyName("occupation")]
	public Occupation Occupation { get; set; }

	/// <summary>
	/// Признак находится ли пользователь сейчас на сайте.
	/// </summary>
	[JsonPropertyName("online")]
	public bool? Online { get; set; }

	/// <summary>
	/// Жизненная позиция.
	/// </summary>
	/// <remarks>
	/// поле <c> personal </c>
	/// </remarks>
	[JsonPropertyName("personal")]
	public StandInLife StandInLife { get; set; }

	/// <summary>
	/// url квадратной фотографии пользователя, имеющей ширину 50 пикселей. В случае
	/// отсутствия у пользователя фотографии
	/// возвращается http://vk.com/images/camera_c.gif
	/// </summary>
	[JsonPropertyName("photo_50")]
	public Uri Photo50 { get; set; }

	/// <summary>
	/// url квадратной фотографии пользователя, имеющей ширину 100 пикселей. В случае
	/// отсутствия у пользователя фотографии
	/// возвращается http://vk.com/images/camera_b.gif.
	/// </summary>
	[JsonPropertyName("photo_100")]
	public Uri Photo100 { get; set; }

	/// <summary>
	/// url фотографии пользователя, имеющей ширину 200 пикселей. В случае отсутствия у
	/// пользователя фотографии
	/// возвращается http://vk.com/images/camera_a.gif.
	/// </summary>
	[JsonPropertyName("photo_200_orig")]
	public Uri Photo200Orig { get; set; }

	/// <summary>
	/// url квадратной фотографии пользователя, имеющей ширину 200 пикселей. Если
	/// фотография была загружена давно,
	/// изображения с такими размерами может не быть, в этом случае ответ не будет
	/// содержать этого поля.
	/// </summary>
	[JsonPropertyName("photo_200")]
	public Uri Photo200 { get; set; }

	/// <summary>
	/// url фотографии пользователя, имеющей ширину 400 пикселей.
	/// Если у пользователя отсутствует фотография такого размера, ответ не будет
	/// содержать этого поля.
	/// </summary>
	[JsonPropertyName("photo_400_orig")]
	public Uri Photo400Orig { get; set; }

	/// <summary>
	/// id главной фотографии профиля пользователя в формате user_id+photo_id,
	/// например, 6492_192164258.
	/// В некоторых случаях (если фотография была установлена очень давно) это поле не
	/// возвращается.
	/// </summary>
	[JsonPropertyName("photo_id")]
	public string PhotoId { get; set; }

	/// <summary>
	/// url квадратной фотографии пользователя с максимальной шириной.
	/// Может быть возвращена фотография, имеющая ширину как 200, так и 100 пикселей.
	/// В случае отсутствия у пользователя фотографии возвращается
	/// http://vk.com/images/camera_b.gif.
	/// </summary>
	[JsonPropertyName("photo_max")]
	public Uri PhotoMax { get; set; }

	/// <summary>
	/// url фотографии пользователя максимального размера.
	/// Может быть возвращена фотография, имеющая ширину как 400, так и 200 пикселей.
	/// В случае отсутствия у пользователя фотографии возвращается
	/// http://vk.com/images/camera_a.gif.
	/// </summary>
	[JsonPropertyName("photo_max_orig")]
	public Uri PhotoMaxOrig { get; set; }

	/// <summary>
	/// Избранные пользователем цитаты.
	/// </summary>
	[JsonPropertyName("quotes")]
	public string Quotes { get; set; }

	/// <summary>
	/// Родственники пользователя.
	/// </summary>
	[JsonPropertyName("relatives")]
	public ReadOnlyCollection<Relative> Relatives { get; set; }

	/// <summary>
	/// Семейное положение.
	/// </summary>
	[JsonPropertyName("relation")]
	public RelationType? Relation { get; set; }

	/// <summary>
	/// Школы, в которых учился пользователь.
	/// </summary>
	[JsonPropertyName("schools")]
	public ReadOnlyCollection<School> Schools { get; set; }

	/// <summary>
	/// Короткое имя (поддомен) страницы пользователя.
	/// </summary>
	[JsonPropertyName("screen_name")]
	public string ScreenName { get; set; }

	/// <summary>
	/// Пол пользователя.
	/// </summary>
	[JsonPropertyName("sex")]
	public Sex? Sex { get; set; }

	/// <summary>
	/// Возвращает указанный в профиле сайт пользователя.
	/// </summary>
	[JsonPropertyName("site")]
	public string Site { get; set; }

	/// <summary>
	/// Строка со статусом пользователя.
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; }

	/// <summary>
	/// Объект аудиозаписи, установленной в статус (если аудиозапись транслируется в текущей момент).
	/// </summary>
	[JsonPropertyName("status_audio")]
	public Audio StatusAudio { get; set; }

	/// <summary>
	/// Часовой пояс пользователя.
	/// </summary>
	[JsonPropertyName("timezone")]
	public int? Timezone { get; set; }

	/// <summary>
	/// Возвращается 1, если запрашиваемый пользователь находится в черном списке у
	/// текущего пользователя.
	/// </summary>
	[JsonPropertyName("trending")]
	public bool Trending { get; set; }

	/// <summary>
	/// Любимые телешоу пользователя.
	/// </summary>
	[JsonPropertyName("tv")]
	public string Tv { get; set; }

	/// <summary>
	/// Список высших учебных заведений, в которых учился пользователь.
	/// </summary>
	[JsonPropertyName("universities")]
	public ReadOnlyCollection<University> Universities { get; set; }

	/// <summary>
	/// Возвращается 1, если страница пользователя верифицирована, 0 — если не
	/// верифицирована.
	/// </summary>
	[JsonPropertyName("verified")]
	public bool? Verified { get; set; }

	/// <summary>
	/// Доступно ли комментирование стены (1 — доступно, 0 — недоступно).
	/// </summary>
	[JsonPropertyName("wall_default")]
	public bool WallComments { get; set; }

	#endregion

	#region Поля, установленные экспериментально

	/// <summary>
	/// Информация о ссылках на предпросмотр фотографий пользователя.
	/// </summary>
	[JsonPropertyName("photo_previews")]
	public Previews PhotoPreviews { get; set; }

	/// <summary>
	/// Номер мобильного телефона (если нет записи или скрыт, то null).
	/// </summary>
	[JsonPropertyName("mobile_phone")]
	public string MobilePhone { get; set; }

	/// <summary>
	/// Номер домашнего телефона (если нет записи или скрыт, то null).
	/// </summary>
	[JsonPropertyName("home_phone")]
	public string HomePhone { get; set; }

	/// <summary>
	/// Информация о блокировке пользователя
	/// </summary>
	[JsonPropertyName("ban_info")]
	public BanInfo BanInfo { get; set; }

	/// <summary>
	/// Является ли пользователь заблокированным
	/// </summary>
	[JsonPropertyName("is_deactivated")]
	public bool IsDeactivated { get; set; }

	/// <summary>
	/// Идентификатор языка, установленный в настройках.
	/// </summary>
	[JsonPropertyName("language")]
	public long? Language { get; set; }

	/// <summary>
	/// Признак использует ли пользователь мобильное приложение либо мобильную версию
	/// сайта.
	/// </summary>
	[JsonPropertyName("online_mobile")]
	public bool? OnlineMobile { get; set; }

	/// <summary>
	/// Если пользователь зашёл через приложение, то Id приложения иначе null.
	/// </summary>
	[JsonPropertyName("online_app")]
	public long? OnlineApp { get; set; }

	/// <summary>
	/// Партнер в семейных отношениях.
	/// </summary>
	[JsonPropertyName("relation_partner")]
	public User RelationPartner { get; set; }

	/// <summary>
	/// Идентификатор пользователя, пригласившего пользователя в беседу (для
	/// GetChatUsers).
	/// </summary>
	[JsonPropertyName("invited_by")]
	public long? InvitedBy { get; set; }

	/// <summary>
	/// Видимость даты рождения.
	/// </summary>
	[JsonPropertyName("bdate_visibility")]
	public BirthdayVisibility? BirthdayVisibility { get; set; }

	/// <summary>
	/// Информация о заявке на смену имени.
	/// </summary>
	[JsonPropertyName("change_name_request")]
	public ChangeNameRequest ChangeNameRequest { get; set; }

	/// <summary>
	/// Информация о заявке на смену имени.
	/// </summary>
	public OwnerState OwnerState { get; set; }

	#endregion

	#region Поля для Groups.GetMembers

	/// <summary>
	/// Полномочия руководителя (для Groups.GetMembers)
	/// </summary>
	[JsonPropertyName("role")]
	public ManagerRole? Role { get; set; }

	#endregion

	#region Поля для NewsFeed.Get

	/// <summary>
	/// Количество друзей (для Groups.GetMembers)
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }

	#endregion

	#region private

	[JsonPropertyName("uid")]
	private long Uid
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("user_id")]
	private long UserId
	{
		get => Id;
		set => Id = value;
	}

	[JsonPropertyName("phone")]
	private string Phone
	{
		get => MobilePhone;
		set => MobilePhone = value;
	}

	#endregion

	/// <summary>
	/// Идентификатор университета.
	/// </summary>
	[JsonPropertyName("university")]
	public long? UniversityId { get; set; }

	/// <summary>
	/// Название ВУЗа.
	/// </summary>
	[JsonPropertyName("university_name")]
	public string UniversityName { get; set; }

	/// <summary>
	/// Идентификатор факультета.
	/// </summary>
	[JsonPropertyName("faculty")]
	public long? FacultyId { get; set; }

	/// <summary>
	/// Название факультета.
	/// </summary>
	[JsonPropertyName("faculty_name")]
	public string FacultyName { get; set; }

	/// <summary>
	/// Год окончания.
	/// </summary>
	[JsonPropertyName("graduation")]
	public int? Graduation { get; set; }

	#region Поля, установленные экспериментально

	/// <summary>
	/// Форма обучения.
	/// </summary>
	[JsonPropertyName("education_form")]
	public string EducationForm { get; set; }

	/// <summary>
	/// Текущий статус пользователя в высшем учебном заведении.
	/// </summary>
	[JsonPropertyName("education_status")]
	public string EducationStatus { get; set; }

	#endregion

	/// <summary>
	/// Логин в Skype.
	/// </summary>
	[JsonPropertyName("skype")]
	public string Skype { get; set; }

	/// <summary>
	/// Идентификатор акаунта в Facebook.
	/// </summary>
	[JsonPropertyName("facebook")]
	public string Facebook { get; set; }

	/// <summary>
	/// Имя и фамилия в facebook.
	/// </summary>
	[JsonPropertyName("facebook_name")]
	public string FacebookName { get; set; }

	/// <summary>
	/// Акаунт в Instagram.
	/// </summary>
	[JsonPropertyName("instagram")]
	public string Instagram { get; set; }
}