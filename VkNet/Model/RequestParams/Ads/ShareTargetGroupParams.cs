using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Предоставляет доступ к аудитории ретаргетинга другому рекламному кабинету.
/// </summary>
[Serializable]
public class ShareTargetGroupParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Идентификатор аудитории. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("target_group_id")]
	public long TargetGroupId { get; set; }

	/// <summary>
	/// Id клиента, в рекламном кабинете которого находится исходная аудитория.
	/// </summary>
	[JsonPropertyName("client_id")]
	public long? ClientId { get; set; }

	/// <summary>
	/// Id клиента, рекламному кабинету которого необходимо предоставить доступ к аудитории.
	/// </summary>
	[JsonPropertyName("share_with_client_id")]
	public long? ShareWithClientId { get; set; }
}