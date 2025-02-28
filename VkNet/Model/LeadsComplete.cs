using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// При успешном завершении оффера
/// </summary>
[Serializable]
public class LeadsComplete
{
	/// <summary>
	/// Ограничение, установленное у текущего оффера;
	/// </summary>
	[JsonPropertyName("limit")]
	public long Limit { get; set; }

	/// <summary>
	/// Ограничение, установленное у текущего оффера;
	/// </summary>
	[JsonPropertyName("day_limit")]
	public long DayLimit { get; set; }

	/// <summary>
	/// Количество потраченных на акцию голосов;
	/// </summary>
	[JsonPropertyName("spent")]
	public long Spent { get; set; }

	/// <summary>
	/// Стоимость одной выполненной акции;
	/// </summary>
	[JsonPropertyName("cost")]
	public string Cost { get; set; }

	/// <summary>
	/// Режим транзакции (1 — тестовый, 0 — реальный);
	/// </summary>
	[JsonPropertyName("test_mode")]
	public long TestMode { get; set; }

	/// <summary>
	/// Результат выполнения транзакции (всегда равно 1).
	/// </summary>
	[JsonPropertyName("success")]
	public long Success { get; set; }
}