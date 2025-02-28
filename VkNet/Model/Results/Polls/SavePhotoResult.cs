using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода SavePhoto
/// </summary>
[Serializable]
public class SavePhotoResult
{
	/// <summary>
	/// Цвет фотографии
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }

	/// <summary>
	/// Идентификатор загруженной фотографии
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Массив изображений разных размеров
	/// </summary>
	[JsonPropertyName("images")]
	public Image[] Images { get; set; }
}