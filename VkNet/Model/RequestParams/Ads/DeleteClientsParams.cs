using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.deleteClients
/// </summary>
[Serializable]
public class DeleteClientsParams
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