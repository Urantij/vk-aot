using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Обложка чата
/// </summary>
[Serializable]
public class ChatPhoto
{
	/// <summary>
	/// URL копии фотографии с шириной 50 px
	/// </summary>
	[JsonPropertyName("photo_50")]
	public string Photo50 { get; set; }

	/// <summary>
	/// URL копии фотографии с шириной 100 px
	/// </summary>
	[JsonPropertyName("photo_100")]
	public string Photo100 { get; set; }

	/// <summary>
	/// URL копии фотографии с шириной 200 px
	/// </summary>
	[JsonPropertyName("photo_200")]
	public string Photo200 { get; set; }
}