using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Параметры метода create.lookalikeRequest
/// </summary>
[Serializable]
public class CreateLookALikeRequestParams
{
	/// <summary>
	/// Идентификатор клиента, для которого будет создаваться аудитория.
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }

	/// <summary>
	/// Идентификатор рекламного кабинета.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Тип источника исходной аудитории.
	/// </summary>
	[JsonPropertyName("source_type")]
	public SourceType? SourceType { get; set; }

	/// <summary>
	/// Идентификатор аудитории ретаргетинга.
	/// </summary>
	[JsonPropertyName("retargeting_group_id")]
	public long? RetargetingGroupId { get; set; }
}