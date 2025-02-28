using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Данные о сервере
/// </summary>
[Serializable]
public class CallbackServerItem
{
	/// <summary>
	/// Идентификатор сервера
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Название сервера
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который добавил сервер (может содержать 0)
	/// </summary>
	[JsonPropertyName("creator_id")]
	public long CreatorId { get; set; }

	/// <summary>
	/// URL сервера
	/// </summary>
	[JsonPropertyName("url")]
	public string Url { get; set; }

	/// <summary>
	/// Секретный ключ
	/// </summary>
	[JsonPropertyName("secret_key")]
	public string SecretKey { get; set; }

	/// <summary>
	/// Статус сервера
	/// </summary>
	[JsonPropertyName("status")]
	public CallbackServerStatus? Status { get; set; }
}