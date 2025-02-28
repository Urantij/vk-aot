using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Описание рекламного аккаунта.
/// </summary>
/// <remarks>
/// См. описание https://vk.com/dev/ads.getAccounts
/// </remarks>
[Serializable]
public class OfficeUsersAccesses
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("client_id")]
	public long ClientId { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("role")]
	public AccessRole? Role { get; set; }
}