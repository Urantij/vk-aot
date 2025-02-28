using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о телефонных номерах пользователя.
/// </summary>
[Serializable]
public class Contacts
{
	/// <summary>
	/// Номер мобильного телефона пользователя (только для Standalone-приложений).
	/// </summary>
	[JsonPropertyName("mobile_phone")]
	public string MobilePhone { get; set; }

	/// <summary>
	/// Дополнительный номер телефона пользователя.
	/// </summary>
	[JsonPropertyName("home_phone")]
	public string HomePhone { get; set; }
}