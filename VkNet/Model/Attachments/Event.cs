using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Встреча
/// </summary>
[Serializable]
public class Event : MediaAttachment
{
	/// <inheritdoc />
	protected override string Alias => "event";

	/// <summary>
	/// Время начала встречи в Unixtime
	/// </summary>
	[JsonPropertyName("time")]
	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime Time { get; set; }

	/// <summary>
	/// Идёт ли текущий пользователь на встречу.
	/// </summary>
	[JsonPropertyName("member_status")]
	public EventMemberStatus MemberStatus { get; set; }

	/// <summary>
	/// Добавлена ли встреча в закладки.
	/// </summary>
	[JsonPropertyName("is_favorite")]
	public bool IsFavorite { get; set; }

	/// <summary>
	/// Место проведения встречи.
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; }

	/// <summary>
	/// Текст для отображения сниппета.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }

	/// <summary>
	/// Текст на кнопке сниппета.
	/// </summary>
	[JsonPropertyName("button_text")]
	public string ButtonText { get; set; }

	/// <summary>
	/// Список идентификаторов друзей, которые также идут на мероприятие.
	/// </summary>
	[JsonPropertyName("friends")]
	public IEnumerable<ulong> Friends { get; set; }
}