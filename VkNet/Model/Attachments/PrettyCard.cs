using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Карточка приложения
/// </summary>
[Serializable]
public class PrettyCard
{
	/// <summary>
	/// Идентификатор карточки
	/// </summary>
	[JsonPropertyName("card_id")]
	public string CardId { get; set; }

	/// <summary>
	/// Ссылка на цель
	/// </summary>
	[JsonPropertyName("link_url_target")]
	public string LinkUrlTarget { get; set; }

	/// <summary>
	/// Ссылка
	/// </summary>
	[JsonPropertyName("link_url")]
	public string LinkUrl { get; set; }

	/// <summary>
	/// Заголовок
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Кнопка
	/// </summary>
	[JsonPropertyName("button")]
	public Button Button { get; set; }

	/// <summary>
	/// Фотографии
	/// </summary>
	[JsonPropertyName("images")]
	public ReadOnlyCollection<Photo> Images { get; set; }

	/// <summary>
	/// Текст кнопки.
	/// </summary>
	[JsonPropertyName("button_text")]
	public string ButtonText { get; set; }

	/// <summary>
	/// Идентификатор фотографии.
	/// </summary>
	[JsonPropertyName("photo")]
	public string Photo { get; set; }

	/// <summary>
	/// Цена.
	/// </summary>
	[JsonPropertyName("price")]
	public string Price { get; set; }

	/// <summary>
	/// Старая цена.
	/// </summary>
	[JsonPropertyName("price_old")]
	public string PriceOld { get; set; }
}