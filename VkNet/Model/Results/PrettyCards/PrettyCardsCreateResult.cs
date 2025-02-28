using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода PrettyCards.Create
/// </summary>
[Serializable]
public class PrettyCardsCreateResult
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
}