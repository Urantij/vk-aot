using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Ads.UploadUrl
/// </summary>
[Serializable]
public class UploadUrlResult
{
	/// <summary>
	/// В случае удачной загрузки
	/// </summary>
	[JsonPropertyName("photo")]
	public string Photo { get; set; }

	/// <summary>
	/// В случае ошибки
	/// </summary>
	[JsonPropertyName("errcode")]
	public int ErrCode { get; set; }
}