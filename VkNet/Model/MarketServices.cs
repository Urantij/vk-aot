using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о продукте.
/// </summary>
[Serializable]
public class MarketServices
{
	/// <summary>
	/// Id
	/// </summary>
	[JsonPropertyName("contact_id")]
	public long ContactId { get; set; }

	/// <summary>
	/// Цена
	/// </summary>
	[JsonPropertyName("currency")]
	public Currency Price { get; set; }

	/// <summary>
	/// Признак активности
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Признак возможности отправки сообщений
	/// </summary>
	[JsonPropertyName("can_message")]
	public bool? CanMessage { get; set; }

	/// <summary>
	/// Признак возможности комментировать
	/// </summary>
	[JsonPropertyName("comments_enabled")]
	public bool? CommentsEnabled { get; set; }
}