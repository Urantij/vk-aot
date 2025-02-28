using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.addOfficeUsers
/// </summary>
[Serializable]
public class CreateAdsResult
{
	/// <summary>
	/// Идентификатор созданного объявления.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("error_code")]
	public long ErrorCode { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("error_desc")]
	public string ErrorDesc { get; set; }
}