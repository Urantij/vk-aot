using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Элемент расписания
/// </summary>
/// <remarks>
/// Время передается в минутах от 0 часов.
/// </remarks>
[Serializable]
public class TimetableItem
{
	/// <summary>
	/// Время начала работы
	/// </summary>
	[JsonPropertyName("open_time")]
	public uint OpenTime { get; set; }

	/// <summary>
	/// Время окончания работы
	/// </summary>
	[JsonPropertyName("close_time")]
	public uint CloseTime { get; set; }

	/// <summary>
	/// Время начала перерыва
	/// </summary>
	[JsonPropertyName("break_open_time")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public uint? BreakOpenTime { get; set; }

	/// <summary>
	/// Время окончания перерыва
	/// </summary>
	[JsonPropertyName("break_close_time")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public uint? BreakCloseTime { get; set; }
}