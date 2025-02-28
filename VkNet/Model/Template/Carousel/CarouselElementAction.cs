using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Объект, описывающий действие, которое необходимо выполнить при нажатии на элемент карусели.
/// Поддерживается два действия:
/// open_link - открыть ссылку из поля "link".
/// open_photo - открыть фото текущего элемента карусели.
/// </summary>
[Serializable]
public class CarouselElementAction
{
	/// <summary>
	/// Тип клавиши.
	/// </summary>
	[JsonPropertyName("type")]
	public CarouselElementActionType? Type { get; set; }

	/// <summary>
	/// ссылка, которую необходимо открыть по нажатию на кнопку.
	/// </summary>
	[JsonPropertyName("link")]
	public Uri Link { get; set; }
}