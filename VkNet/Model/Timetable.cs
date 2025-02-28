using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Расписание
/// </summary>
[Serializable]
public class Timetable
{
	/// <summary>
	/// Понедельник
	/// </summary>
	[JsonPropertyName("mon")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Monday { get; set; }

	/// <summary>
	/// Вторник
	/// </summary>
	[JsonPropertyName("tue")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Tuesday { get; set; }

	/// <summary>
	/// Среда
	/// </summary>
	[JsonPropertyName("wed")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Wednesday { get; set; }

	/// <summary>
	/// Четверг
	/// </summary>
	[JsonPropertyName("thu")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Thursday { get; set; }

	/// <summary>
	/// Пятница
	/// </summary>
	[JsonPropertyName("fri")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Friday { get; set; }

	/// <summary>
	/// Суббота
	/// </summary>
	[JsonPropertyName("sat")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Saturday { get; set; }

	/// <summary>
	/// Воскресенье
	/// </summary>
	[JsonPropertyName("sun")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public TimetableItem Sunday { get; set; }
}