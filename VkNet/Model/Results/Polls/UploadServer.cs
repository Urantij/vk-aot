using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода GetPhotoUploadServer
/// </summary>
[Serializable]
public class UploadServer
{
	/// <summary>
	/// Идентификатор владельца опроса.
	/// </summary>
	[JsonPropertyName("upload_url")]
	public string UploadUrl { get; set; }
}