using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о социальных контактах пользователя.
/// См. описание
/// <see href="https://vk.com/dev/objects/user" />
/// Экспериментально установлено, что поля находятся непосредственно в полях
/// объекта User.
/// </summary>
[Serializable]
public class Connections
{
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
	/// Акаунт в twitter.
	/// </summary>
	[JsonPropertyName("twitter")]
	public string Twitter { get; set; }

	/// <summary>
	/// Акаунт в Instagram.
	/// </summary>
	[JsonPropertyName("instagram")]
	public string Instagram { get; set; }
}