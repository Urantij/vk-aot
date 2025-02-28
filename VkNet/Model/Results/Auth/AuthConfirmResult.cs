using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода auth.confirm
/// </summary>
[Serializable]
public class AuthConfirmResult
{
	/// <summary>
	/// Успешно.
	/// </summary>
	[JsonPropertyName("success")]
	public bool Success { get; set; }

	/// <summary>
	/// Идентификатор пользователя.
	/// </summary>
	[JsonPropertyName("uid")]
	public long UserId { get; set; }
}