using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Описание рекламного аккаунта.
/// </summary>
/// <remarks>
/// См. описание https://vk.com/dev/ads.getAccounts
/// </remarks>
[Serializable]
public class GetClientsResult
{
	/// <summary>
	/// Идентификатор рекламного объявления.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Общий лимит объявления в рублях. 0 — лимит не задан.
	/// </summary>
	[JsonPropertyName("all_limit")]
	public long AllLimit { get; set; }
}