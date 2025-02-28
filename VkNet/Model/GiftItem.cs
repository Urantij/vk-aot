using System;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Подарок.
/// </summary>
[Serializable]
public class GiftItem
{
	/// <summary>
	/// Идентификатор полученного подарка.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// Идентификатор пользователя, который отправил подарок, или 0, если отправитель
	/// скрыт.
	/// </summary>
	[JsonPropertyName("from_id")]
	public long FromId { get; set; }

	/// <summary>
	/// Текст сообщения, приложенного к подарку.
	/// </summary>
	[JsonPropertyName("message")]
	public string Message { get; set; }

	/// <summary>
	/// Время отправки подарка в формате unixtime.
	/// </summary>
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonPropertyName("date")]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Подарок.
	/// </summary>
	[JsonPropertyName("gift")]
	public Gift Gift { get; set; }

	/// <summary>
	/// Значение приватности подарка (только для текущего пользователя).
	/// </summary>
	[JsonPropertyName("privacy")]
	public GiftPrivacy Privacy { get; set; }

	/// <summary>
	/// Хеш подарка
	/// </summary>
	[JsonPropertyName("gift_hash")]
	public string GiftHash { get; set; }
}