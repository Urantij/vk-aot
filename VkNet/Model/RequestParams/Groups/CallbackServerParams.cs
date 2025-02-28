using System;
using System.Text.Json.Serialization;
using VkNet.Infrastructure;

namespace VkNet.Model;

/// <summary>
/// Параметры настройки уведомлений о событиях в Callback API.
/// </summary>
[Serializable]
public class CallbackServerParams
{
	/// <summary>
	/// идентификатор сообщества.
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong? GroupId { get; set; }

	/// <summary>
	/// идентификатор сервера.
	/// </summary>
	[JsonPropertyName("server_id")]
	public long? ServerId { get; set; }

	/// <summary>
	/// Версия Callback API.
	/// </summary>
	[JsonPropertyName("api_version")]
	public VkApiVersionManager ApiVersion { get; set; }

	/// <summary>
	/// Настройки уведомлений
	/// </summary>
	[JsonPropertyName("callback_settings")]
	public CallbackSettings CallbackSettings { get; set; }
}