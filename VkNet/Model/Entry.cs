using System;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Последние действия пользователей по рекламной акции
/// </summary>
[Serializable]
public class Entry
{
	/// <summary>
	/// Время действия в формате unixtime;
	/// </summary>
	[JsonPropertyName("date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? Date { get; set; }

	/// <summary>
	/// 0 - начало действия, 1 - завершение действия, 2 - блокирование пользователя;
	/// </summary>
	[JsonPropertyName("status")]
	public int? Status { get; set; }

	/// <summary>
	/// Идентификатор пользователя;
	/// </summary>
	[JsonPropertyName("uid")]
	public int? Uid { get; set; }

	/// <summary>
	/// Текст комментария.
	/// </summary>
	[JsonPropertyName("comment")]
	public string Comment { get; set; }

	/// <summary>
	/// Идентификатор приложения, из которого было выполнено действие;
	/// </summary>
	[JsonPropertyName("aid")]
	public int? Aid { get; set; }

	/// <summary>
	/// 0 - рабочий режим, 1 - тестовый режим;
	/// </summary>
	[JsonPropertyName("test_mode")]
	public int? TestMode { get; set; }

	/// <summary>
	/// Время начала действия в формате unixtime для status = 1;
	/// </summary>
	[JsonPropertyName("start_date")]
	[JsonConverter(converterType: typeof(UnixDateTimeConverter))]
	public DateTime? StartDate { get; set; }

	/// <summary>
	/// Идентификатор сессии;
	/// </summary>
	[JsonPropertyName("sid")]
	public string Sid { get; set; }
}