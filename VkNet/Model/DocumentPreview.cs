using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация для предварительного просмотра документа
/// </summary>
[Serializable]
public class DocumentPreview
{
	/// <summary>
	/// Изображения для предпросмотра.
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Данные о граффити
	/// </summary>
	[JsonPropertyName("graffiti")]
	public Graffiti Graffiti { get; set; }

	/// <summary>
	/// Данные об аудиосообщении.
	/// </summary>
	[JsonPropertyName("audio_message")]
	public AudioMessage AudioMessage { get; set; }
}