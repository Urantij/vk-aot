using System;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace VkNet.Model;

/// <summary>
/// Результат обновления пользователей оффиса
/// </summary>
[Serializable]
public class UpdateOfficeUsersResult
{
	/// <summary>
	/// Идентификатор пользователя, добавляемого как администратор/наблюдатель.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Был ли пользователь успешно изменен.
	/// </summary>
	[JsonPropertyName("is_success")]
	public bool IsSuccess { get; set; }

	/// <summary>
	/// Если IsSuccess=false также возвращается объект error с описанием ошибки.
	/// </summary>
	[JsonPropertyName("error")]
	[CanBeNull]
	public VkError Error { get; set; }
}