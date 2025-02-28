using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода groups.toggleMarket
/// </summary>
[Serializable]
public class GroupToggleMarketParams
{
	/// <summary>
	/// идентификатор сообщества.
	/// положительное число, обязательный параметр
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// Значение переключателя
	/// </summary>
	[JsonPropertyName("state")]
	public ToggleMarketState? State { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("ref")]
	public string Ref { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("utm_source")]
	public string UtmSource { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("utm_medium")]
	public string UtmMedium { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("utm_campaign")]
	public string UtmCampaign { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("utm_content")]
	public string UtmContent { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("utm_term")]
	public string UtmTerm { get; set; }

	/// <summary>
	/// Эксперементально
	/// </summary>
	[JsonPropertyName("promocode")]
	public string Promocode { get; set; }
}