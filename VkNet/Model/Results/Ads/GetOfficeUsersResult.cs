using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Описание рекламного аккаунта.
/// </summary>
/// <remarks>
/// См. описание https://vk.com/dev/ads.getAccounts
/// </remarks>
[Serializable]
public class GetOfficeUsersResult
{
	/// <summary>
	/// Количество оставшихся методов;
	/// </summary>
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	/// <summary>
	/// Время до следующего обновления в секундах.
	/// </summary>
	[JsonPropertyName("accesses")]
	public ReadOnlyCollection<OfficeUsersAccesses> Accesses { get; set; }
}