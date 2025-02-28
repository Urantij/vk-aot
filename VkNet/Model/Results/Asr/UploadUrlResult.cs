using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект UploadUrl
/// </summary>
[Serializable]
public class AsrUploadUrlResult
{
	/// <summary>
	/// Ссылка на адрес сервера для загрузки аудиозаписи
	/// </summary>
	[JsonPropertyName("upload_url")]
	public Uri UploadUrl { get; set; }
}