using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат авторизаци
/// </summary>
[Serializable]
public class AuthorizationResult
{
	/// <summary>
	/// Access Token
	/// </summary>
	[JsonPropertyName("access_token")]
	public string AccessToken { get; set; }

	/// <summary>
	/// Время истечения токена
	/// </summary>
	[JsonPropertyName("expires_in")]
	public int ExpiresIn { get; set; }

	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Произвольная строка, которая будет возвращена вместе с результатом авторизации.
	/// </summary>
	[JsonPropertyName("state")]
	public string State { get; set; }
}