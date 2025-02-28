using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.removeTargetContacts
/// </summary>
[Serializable]
public class RemoveOfficeUsersParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Массив, содержащий id удаляемых администраторов
	/// </summary>
	[JsonPropertyName("ids")]
	public string[] Ids { get; set; }
}