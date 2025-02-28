using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Информация о заявке на смену имени.
/// </summary>
[Serializable]
public class NameRequest
{
	/// <summary>
	/// Идентификатор заявки, необходимый для её отмены (только если
	/// ChangeNameRequest.Status
	/// </summary>
	[JsonPropertyName("id")]
	public int? Id { get; set; }

	/// <summary>
	/// Статус заявки
	/// </summary>
	[JsonPropertyName("status")]
	public ChangeNameStatus? Status { get; set; }

	/// <summary>
	/// Дата, после которой возможна повторная подача заявки.
	/// </summary>
	[JsonPropertyName("repeat_date")]
	public string RepeatDate { get; set; }

	/// <summary>
	/// Имя пользователя, указанное в заявке
	/// </summary>
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; }

	/// <summary>
	/// Фамилия пользователя, указанная в заявке.
	/// </summary>
	[JsonPropertyName("last_name")]
	public string LastName { get; set; }
}