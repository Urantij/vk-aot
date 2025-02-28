using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Контент приложения.
/// </summary>
/// <remarks>
/// Это устаревший тип вложений. Он может быть возвращен лишь для записей, созданных раньше 2013 года.
/// <a href="http://vk.com/dev/attachments_w" > Документация </a>
/// </remarks>
[Serializable]
public class ApplicationContent : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "app";

	/// <summary>
	/// Название приложения.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }

	/// <summary>
	/// URL изображения для предпросмотра.
	/// </summary>
	[JsonPropertyName("photo_130")]
	public string Photo130 { get; set; }

	/// <summary>
	/// URL полноразмерного изображения.
	/// </summary>
	[JsonPropertyName("photo_604")]
	public string Photo604 { get; set; }
}