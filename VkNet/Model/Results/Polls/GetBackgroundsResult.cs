using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Результат метода GetBackgrounds
/// </summary>
[Serializable]
public class GetBackgroundsResult
{
	/// <summary>
	/// Тип фона.
	/// </summary>
	[JsonPropertyName("type")]
	public PollBackgroundType? Type { get; set; }

	/// <summary>
	/// Угол градиента по оси X.
	/// </summary>
	[JsonPropertyName("angle")]
	public string Angle { get; set; }

	/// <summary>
	/// HEX-код замещающего цвета (без #).
	/// </summary>
	[JsonPropertyName("color")]
	public string Color { get; set; }

	/// <summary>
	/// Ширина плитки паттерна.
	/// </summary>
	[JsonPropertyName("width")]
	public long Width { get; set; }

	/// <summary>
	/// Высота плитки паттерна.
	/// </summary>
	[JsonPropertyName("height")]
	public long Height { get; set; }

	/// <summary>
	/// Точки градиента.
	/// </summary>
	[JsonPropertyName("points")]
	public PollBackgroundPoint[] Points { get; set; }

	/// <summary>
	/// Идентификатор фона.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }
}