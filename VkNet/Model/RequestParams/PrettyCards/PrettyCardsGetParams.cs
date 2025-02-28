using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Список параметров для метода PrettyCards.get
/// </summary>
[Serializable]
public class PrettyCardsGetParams
{
	/// <summary>
	/// Идентификатор владельца карточки.
	/// </summary>
	[JsonPropertyName("owner_id")]
	public long? OwnerId { get; set; }

	/// <summary>
	/// Смещение относительно начала списка карточек
	/// </summary>
	[JsonPropertyName("offset")]
	public long? Offset { get; set; }

	/// <summary>
	/// Количество возвращаемых карточек.
	/// </summary>
	[JsonPropertyName("count")]
	public long? Count { get; set; }
}