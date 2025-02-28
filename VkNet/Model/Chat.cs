using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace VkNet.Model;

/// <summary>
/// Информация о беседе (мультидиалоге, чате).
/// См. описание http://vk.com/dev/chat_object
/// </summary>
[Serializable]
public class Chat
{
	/// <summary>
	/// Идентификатор беседы.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Тип диалога.
	/// </summary>
	[JsonPropertyName("type")]
	public string Type { get; set; }

	/// <summary>
	/// Название беседы.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который является создателем беседы.
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long? AdminId { get; set; }

	/// <summary>
	/// Список идентификаторов участников беседы.
	/// </summary>
	[JsonPropertyName("users")]
	public ReadOnlyCollection<long> Users { get; set; }

	/// <summary>
	/// Настройки оповещений для диалога..
	/// </summary>
	[JsonPropertyName("push_settings")]
	[CanBeNull]
	public ChatPushSettings PushSettings { get; set; }

	/// <summary>
	/// URL изображения-обложки чата шириной 50 px (если доступно).
	/// </summary>
	[JsonPropertyName("photo_50")]
	public string Photo50 { get; set; }

	/// <summary>
	/// URL изображения-обложки чата шириной 100 px (если доступно).
	/// </summary>
	[JsonPropertyName("photo_100")]
	public string Photo100 { get; set; }

	/// <summary>
	/// URL изображения-обложки чата шириной 200 px (если доступно).
	/// </summary>
	[JsonPropertyName("photo_200")]
	public string Photo200 { get; set; }

	/// <summary>
	/// флаг, указывающий, что пользователь покинул беседу. Всегда содержит 1.
	/// </summary>
	[JsonPropertyName("left")]
	public bool Left { get; set; }

	/// <summary>
	/// флаг, указывающий, что пользователь был исключен из беседы. Всегда содержит 1.
	/// </summary>
	[JsonPropertyName("kicked")]
	public bool Kicked { get; set; }
}