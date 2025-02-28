using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры проверки ссылки
/// </summary>
[Serializable]
public class CheckLinkParams
{
	/// <summary>
	/// Идентификатор пользователя
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Тип ссылки рекламы
	/// </summary>
	[JsonPropertyName("link_type")]
	public AdsLinkType? LinkType { get; set; }

	/// <summary>
	/// Ссылка
	/// </summary>
	[JsonPropertyName("link_url")]
	public Uri LinkUrl { get; set; }

	/// <summary>
	/// Идентификатор кампании
	/// </summary>
	[JsonPropertyName("campaign_id")]
	public long? CampaignId { get; set; }
}