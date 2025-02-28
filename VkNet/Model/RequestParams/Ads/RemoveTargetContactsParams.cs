using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.removeTargetContacts
/// </summary>
[Serializable]
public class RemoveTargetContactsParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("target_group_id")]
	public long TargetGroupId { get; set; }

	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("contacts")]
	public List<string> Contacts { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }
}