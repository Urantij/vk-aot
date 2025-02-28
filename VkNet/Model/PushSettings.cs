using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Настройки Push-уведомлений
/// </summary>
[Serializable]
[JsonConverter(typeof(PushSettingsJsonConverter))]
public class PushSettings
{
	/// <summary>
	/// Личные сообщения. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("msg")]
	public MessagesPushSettings Msg { get; set; }

	/// <summary>
	/// Групповые чаты. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("chat")]
	public MessagesPushSettings Chat { get; set; }

	/// <summary>
	/// Запрос на добавления в друзья. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("friend")]
	public bool? Friend { get; set; }

	/// <summary>
	/// Регистрация импортированного контакта.
	/// </summary>
	[JsonPropertyName("friend_found")]
	public bool? FriendFound { get; set; }

	/// <summary>
	/// Подтверждение заявки в друзья.
	/// </summary>
	[JsonPropertyName("friend_accepted")]
	public bool? FriendAccepted { get; set; }

	/// <summary>
	/// Ответы.
	/// </summary>
	[JsonPropertyName("reply")]
	public bool? Reply { get; set; }

	/// <summary>
	/// Комментарии. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("comment")]
	public bool? Comment { get; set; }

	/// <summary>
	/// Упоминания. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("mention")]
	public bool? Mention { get; set; }

	/// <summary>
	/// Отметки "Мне нравится". Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("like")]
	public bool? Like { get; set; }

	/// <summary>
	/// Действия "Рассказать друзьям". Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("repost")]
	public bool? Repost { get; set; }

	/// <summary>
	/// Новая запись на стене пользователя.
	/// </summary>
	[JsonPropertyName("wall_post")]
	public bool? WallPost { get; set; }

	/// <summary>
	/// Размещение предложенной новости.
	/// </summary>
	[JsonPropertyName("wall_publish")]
	public bool? WallPublish { get; set; }

	/// <summary>
	/// Приглашение в сообщество.
	/// </summary>
	[JsonPropertyName("group_invite")]
	public bool? GroupInvite { get; set; }

	/// <summary>
	/// Подтверждение заявки на вступление в группу.
	/// </summary>
	[JsonPropertyName("group_accepted")]
	public bool? GroupAccepted { get; set; }

	/// <summary>
	/// Ближайшие мероприятия.
	/// </summary>
	[JsonPropertyName("event_soon")]
	public bool? EventSoon { get; set; }

	/// <summary>
	/// Отметки на фотографиях. Может принимать массив значений.
	/// </summary>
	[JsonPropertyName("tag_photo")]
	public bool? TagPhoto { get; set; }

	/// <summary>
	/// Запросы в приложениях.
	/// </summary>
	[JsonPropertyName("app_request")]
	public bool? AppRequest { get; set; }

	/// <summary>
	/// Установка приложения.
	/// </summary>
	[JsonPropertyName("sdk_open")]
	public bool? SdkOpen { get; set; }

	/// <summary>
	/// Записи выбранных людей и сообществ.
	/// </summary>
	[JsonPropertyName("new_post")]
	public bool? NewPost { get; set; }

	/// <summary>
	/// Уведомления о днях рождения на текущую дату.
	/// </summary>
	[JsonPropertyName("birthday")]
	public bool? Birthday { get; set; }
}