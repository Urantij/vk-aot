using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода UpdateCampaigns
/// </summary>
[Serializable]
public class UpdateClientsResult
{
	/// <summary>
	/// Идентификатор обновляемой кампании.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Код ошибки
	/// </summary>
	[JsonPropertyName("error_code")]
	public long ErrorCode { get; set; }

	/// <summary>
	/// Описание ошибки
	/// </summary>
	[JsonPropertyName("error_desc")]
	public string ErrorDesc { get; set; }
}