using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Контакты группы
/// </summary>
[Serializable]
public class Contact
{
	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Должность.
	/// </summary>
	[JsonPropertyName("desc")]
	public string Description { get; set; }

	/// <summary>
	/// Электронная почта.
	/// </summary>
	[JsonPropertyName("email")]
	public string Email { get; set; }

	/// <summary>
	/// Телефон.
	/// </summary>
	[JsonPropertyName("phone")]
	public string Phone { get; set; }
}