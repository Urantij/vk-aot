using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using VkNet.Enums;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Информация о забанненом (добавленном в черный список) пользователе сообщества.
/// </summary>
/// <remarks>
/// Страница документации ВКонтакте http://vk.com/dev/groups.getBanned
/// </remarks>
[DebuggerDisplay(value: "[{AdminId}] {Comment} ({Reason})")]
[Serializable]
public class BanInfo
{
	/// <summary>
	/// Идентификатор администратора, который добавил пользователя в черный список.
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long? AdminId { get; set; }

	/// <summary>
	/// Дата добавления пользователя в черный список.
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// Текст комментария к бану.
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }

	/// <summary>
	/// Дата, когда пользователь будет разбанен.
	/// </summary>
	[JsonPropertyName("end_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? EndDate { get; set; }

	/// <summary>
	/// Причина добавления пользователя в черный список.
	/// </summary>
	[JsonPropertyName("reason")]
	public BanReason Reason { get; set; }
}