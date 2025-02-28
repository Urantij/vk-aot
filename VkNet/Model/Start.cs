using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// При успешном старте рекламной акции
/// </summary>
[Serializable]
public class Start
{
	/// <summary>
	/// Сессия рекламной акции.
	/// </summary>
	[JsonPropertyName("vk_sid")]
	public string VkSid { get; set; }

	/// <summary>
	/// Режим транзакции (1 — тестовый, 0 — реальный);
	/// </summary>
	[JsonPropertyName("test_mode")]
	public int? TestMode { get; set; }
}