using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Доступна ли рекламная акция пользователю.
/// </summary>
[Serializable]
public class CheckUserParams
{
	/// <summary>
	/// Идентификатор рекламной акции
	/// </summary>
	[JsonPropertyName("lead_id")]
	public ulong LeadId { get; set; }

	/// <summary>
	/// Двухбуквенный код страны пользователя (ISO 3166-1 alpha-2, также известный как
	/// ISO2).
	/// </summary>
	[JsonPropertyName("country")]
	public Iso3166 Country { get; set; }

	/// <summary>
	/// При использовании тестового режима функция вернёт result, соответствующий
	/// значению этого параметра.
	/// </summary>
	[JsonPropertyName("test_result")]
	public ulong TestResult { get; set; }

	/// <summary>
	/// 1 -- включить тестовый режим;
	/// 0 -- включить боевой режим.
	/// </summary>
	[JsonPropertyName("test_mode")]
	public bool TestMode { get; set; }

	/// <summary>
	/// Автоматический старт акции при успешной проверке. Доступно по согласованию с
	/// администрацией.
	/// </summary>
	[JsonPropertyName("auto_start")]
	public bool AutoStart { get; set; }

	/// <summary>
	/// Возраст пользователя.
	/// </summary>
	[JsonPropertyName("age")]
	public ulong Age { get; set; }
}