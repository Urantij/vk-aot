using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Возвращает данные о точках, по которым вырезаны профильная и миниатюрная
/// фотографии пользователя.
/// </summary>
[Serializable]
public class CropPhoto
{
	/// <summary>
	/// Объект photo фотографии пользователя из которой вырезается профильная аватарка.
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }

	/// <summary>
	/// Вырезанная фотография пользователя, поля: x, y, x2, y2, координаты указаны в
	/// процентах.
	/// </summary>
	[JsonPropertyName("crop")]
	public Rect Crop { get; set; }

	/// <summary>
	/// Миниатюрная квадратная фотография, вырезанная из фотографии Crop: x, y, x2, y2,
	/// координаты также указаны в
	/// процентах;
	/// </summary>
	[JsonPropertyName("rect")]
	public Rect Rect { get; set; }
}