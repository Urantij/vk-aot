using System;
using System.Text.Json.Serialization;
using VkNet.Enums.SafetyEnums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Текущее значение
/// </summary>
[Serializable]
public class PrivacySettingsValue
{
	/// <summary>
	/// Категория
	/// </summary>
	[JsonPropertyName("category")]
	[JsonConverter(typeof(SafetyEnumJsonConverter))]
	public Privacy Category { get; set; }

	/// <summary>
	/// Категория
	/// </summary>
	[JsonPropertyName("lists")]
	public PrivacyViewListOwners Lists { get; set; }

	/// <summary>
	/// Категория
	/// </summary>
	[JsonPropertyName("owners")]
	public PrivacyViewListOwners Owners { get; set; }
}