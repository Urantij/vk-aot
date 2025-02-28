using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода downloadedGames.getPaidStatus
/// </summary>
[Serializable]
public class GetPaidStatusResult
{
	/// <summary>
	/// Оплачено пользователем
	/// </summary>
	[JsonPropertyName("is_paid")]
	public bool IsPaid { get; set; }
}