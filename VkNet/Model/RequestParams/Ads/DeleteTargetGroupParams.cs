using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Создаёт пиксель ретаргетинга.
/// </summary>
[Serializable]
public class DeleteTargetGroupParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета.
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Id клиента, в рекламном кабинете которого будет создаваться пиксель.
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }

	/// <summary>
	/// Id пикселя.
	/// </summary>
	[JsonPropertyName("target_group_id")]
	public long TargetGroupId { get; set; }
}