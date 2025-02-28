using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения метода PrettyCards.delete
/// </summary>
[Serializable]
public class PrettyCardsDeleteResult
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