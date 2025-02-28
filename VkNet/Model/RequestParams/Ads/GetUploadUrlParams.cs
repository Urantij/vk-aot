using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Параметры запроса ads.addOfficeUsers
/// </summary>
[Serializable]
public class GetUploadUrlParams
{
	/// <summary>
	/// Идентификатор рекламного кабинета. обязательный параметр, целое число
	/// </summary>
	[JsonPropertyName("ad_format")]
	public AdFormat AdFormat { get; set; }

	/// <summary>
	/// Массив объектов UserSpecification
	/// </summary>
	[JsonPropertyName("icon")]
	public AdIcon Icon { get; set; }
}