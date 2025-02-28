using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Добавление пользователя в чёрный список
/// </summary>
[Serializable]
public class AppPayload : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор приложения, из которого было отправлено событие.
	/// </summary>
	[JsonPropertyName("app_id")]
	public long? AppId { get; set; }

	/// <summary>
	/// Идентификатор сообщества, в которое отправлено уведомление
	/// </summary>
	[JsonPropertyName("group_id ")]
	public long? GroupId { get; set; }

	/// <summary>
	/// блокировке
	/// </summary>
	[JsonPropertyName("payload")]
	public string Payload { get; set; }
}