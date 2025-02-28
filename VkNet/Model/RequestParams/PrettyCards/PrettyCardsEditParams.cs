using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Список параметров для метода prettyCards.edit
/// </summary>
[Serializable]
public class PrettyCardsEditParams
{
	/// <summary>
	/// Идентификатор владельца карточки.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Идентификатор карточки.
	/// </summary>
	[JsonPropertyName("card_id")]
	public string CardId { get; set; }

	/// <summary>
	/// Новая фотография.
	/// </summary>
	[JsonPropertyName("photo")]
	public string Photo { get; set; }

	/// <summary>
	/// Новый заголовок.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Новая ссылка.
	/// </summary>
	[JsonPropertyName("link")]
	public string Link { get; set; }

	/// <summary>
	/// Новая цена.
	/// </summary>
	[JsonPropertyName("price")]
	public string Price { get; set; }

	/// <summary>
	/// Обновлённая старая цена.
	/// </summary>
	[JsonPropertyName("price_old")]
	public string PriceOld { get; set; }

	/// <summary>
	/// Новая кнопка.
	/// </summary>
	[JsonPropertyName("button")]
	public string Button { get; set; }
}