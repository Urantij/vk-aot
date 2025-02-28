using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения метода PrettyCards.getById
/// </summary>
[Serializable]
public class PrettyCardsGetByIdResult
{
	/// <summary>
	/// Идентификатор карточки.
	/// </summary>
	[JsonPropertyName("card_id")]
	public string CardId { get; set; }

	/// <summary>
	/// Целевая ссылка.
	/// </summary>
	[JsonPropertyName("link_url")]
	public string LinkUrl { get; set; }

	/// <summary>
	/// Заголовок.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Идентификатор кнопки
	/// </summary>
	[JsonPropertyName("button")]
	public string Button { get; set; }

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
	/// Массив структур с разными размерами фотографии.
	/// </summary>
	[JsonPropertyName("images")]
	public ReadOnlyCollection<Photo> Images { get; set; }

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