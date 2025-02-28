using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о предложениях.
/// </summary>
[Serializable]
public class InformationAboutOffers
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Заголовок.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Инструкция.
	/// </summary>
	[JsonPropertyName("instruction")]
	public string Instruction { get; set; }

	/// <summary>
	/// Инструкция с html разметкой.
	/// </summary>
	/// <value>
	/// The instruction_html.
	/// </value>
	[JsonPropertyName("instruction_html")]
	public string InstructionHtml { get; set; }

	/// <summary>
	/// Краткое описание.
	/// </summary>
	[JsonPropertyName("short_description")]
	public string ShortDescription { get; set; }

	/// <summary>
	/// Описание.
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; }

	/// <summary>
	/// Ссылка на изображение.
	/// </summary>
	[JsonPropertyName("img")]
	public Uri Img { get; set; }

	/// <summary>
	/// Тег.
	/// </summary>
	[JsonPropertyName("tag")]
	public string Tag { get; set; }

	/// <summary>
	/// Цена.
	/// </summary>
	[JsonPropertyName("price")]
	public long Price { get; set; }
}