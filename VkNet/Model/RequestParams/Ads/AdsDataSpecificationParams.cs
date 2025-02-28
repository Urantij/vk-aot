using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.addOfficeUsers
/// </summary>
[Serializable]
public class AdsDataSpecificationParams<TSpecification>
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("account_id")]
	public long AccountId { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("data")]
	public TSpecification[] Data { get; set; }
}