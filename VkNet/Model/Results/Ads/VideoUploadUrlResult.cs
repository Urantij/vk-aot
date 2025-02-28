using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Ads.VideoUploadUrl
/// </summary>
[Serializable]
public class VideoUploadUrlResult
{
	/// <summary>
	/// В случае удачной загрузки
	/// </summary>
	[JsonPropertyName("video")]
	public string Video { get; set; }

	/// <summary>
	/// В случае ошибки
	/// </summary>
	[JsonPropertyName("errcode")]
	public int ErrCode { get; set; }
}