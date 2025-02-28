using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Фон сниппета опроса.
/// </summary>
[Serializable]
public class PollBackground
{
	/// <summary>
	/// Идентификатор фона.
	/// </summary>
	[JsonPropertyName("id")]
	public long? Id { get; set; }

	/// <summary>
	/// Тип фона.
	/// </summary>
	[JsonPropertyName("type")]
	public PollBackgroundType? Type { get; set; }

	/// <summary>
	/// (для type = gradient) угол градиента по оси X.
	/// </summary>
	[JsonPropertyName("angle")]
	public int? Angle { get; set; }

	/// <summary>
	/// HEX-код замещающего цвета (без #).
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }

	/// <summary>
	/// (для type = tile) ширина плитки паттерна.
	/// </summary>
	[JsonPropertyName("width")]
	public int? Width { get; set; }

	/// <summary>
	/// (для type = tile) высота плитки паттерна.
	/// </summary>
	[JsonPropertyName("height")]
	public int? Height { get; set; }

	/// <summary>
	/// (для type = tile) изображение плитки паттерна. Массив объектов изображений.
	/// </summary>
	[JsonPropertyName("images")]
	public ReadOnlyCollection<Photo> Images { get; set; }

	/// <summary>
	/// (для type = gradient) точки градиента.
	/// </summary>
	[JsonPropertyName("points")]
	public ReadOnlyCollection<PollBackgroundPoint> Points { get; set; }
}