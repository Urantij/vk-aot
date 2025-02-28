using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Спецификация офисного пользователя
/// </summary>
[Serializable]
public class OfficeUsersSpecification
{
	/// <summary>
	/// Идентификатор пользователя, добавляемого как администратор/наблюдатель.
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Тип полномочий.
	/// </summary>
	[JsonPropertyName("role")]
	public AccessRole? Role { get; set; }

	/// <summary>
	/// Массив идентификаторов клиента.
	/// </summary>
	[JsonPropertyName("clients_ids")]
	public int[] ClientsIds { get; set; }

	/// <summary>
	/// Доступ ко всем текущим и новым клиентам этого кабинета.
	/// </summary>
	[JsonPropertyName("grant_access_to_all_clients")]
	public bool GrantAccessToAllClients { get; set; }

	/// <summary>
	/// Показывать ли бюджет пользователю.
	/// </summary>
	[JsonPropertyName("view_budget")]
	public bool? ViewBudget { get; set; }
}