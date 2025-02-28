using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Cтатистика объекта за один временной период
/// </summary>
[Serializable]
public class StatisticsStats
{
	/// <summary>
	/// День в формате YYYY-MM-DD
	/// </summary>
	[JsonPropertyName("day")]
	public string Day { get; set; }

	/// <summary>
	/// Месяц в формате YYYY-MM
	/// </summary>
	[JsonPropertyName("month")]
	public string Month { get; set; }

	/// <summary>
	/// Если был запрос на статистику за все время, то значение 1
	/// </summary>
	[JsonPropertyName("overall")]
	public string OverAll { get; set; }

	/// <summary>
	/// Потраченные средства
	/// </summary>
	[JsonPropertyName("spent")]
	public string Spent { get; set; }

	/// <summary>
	/// Потраченные средства
	/// </summary>
	[JsonPropertyName("impressions")]
	public long Impressions { get; set; }

	/// <summary>
	/// Клики
	/// </summary>
	[JsonPropertyName("clicks")]
	public long Clicks { get; set; }

	/// <summary>
	/// Охват
	/// </summary>
	[JsonPropertyName("reach")]
	public long Reach { get; set; }

	/// <summary>
	/// Вступления в группу, событие, подписки на публичную страницу или
	/// установки приложения (только если в объявлении указана прямая ссылка
	/// на соответствующую страницу ВКонтакте)
	/// </summary>
	[JsonPropertyName("join_rate")]
	public long? JoinRate { get; set; }

	/// <summary>
	/// Количество уникальных просмотров
	/// </summary>
	[JsonPropertyName("uniq_views_count")]
	public long UniqViewsCount { get; set; }

	/// <summary>
	/// CTR
	/// </summary>
	[JsonPropertyName("ctr")]
	public string Ctr { get; set; }

	/// <summary>
	/// eCPC
	/// </summary>
	[JsonPropertyName("effective_cost_per_click")]
	public string EffectiveCostPerClick { get; set; }

	/// <summary>
	/// eCPM
	/// </summary>
	[JsonPropertyName("effective_cost_per_mille")]
	public string EffectiveCostPerMille { get; set; }

	/// <summary>
	/// eCPF
	/// </summary>
	[JsonPropertyName("effective_cpf")]
	public string EffectiveCpf { get; set; }

	/// <summary>
	/// Cтоимость сообщения
	/// </summary>
	[JsonPropertyName("effective_cost_per_message")]
	public string EffectiveCostPerMessage { get; set; }

	/// <summary>
	/// Количество сообщений
	/// </summary>
	[JsonPropertyName("message_sends_by_any_user")]
	public long? MessageSendsByAnyUser { get; set; }

	/// <summary>
	/// Cколько пользователей включили видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_started")]
	public long? VideoPlaysUniqueStarted { get; set; }

	/// <summary>
	/// Cколько пользователей посмотрели 3 секунды видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_3_seconds")]
	public long? VideoPlaysUnique3Seconds { get; set; }

	/// <summary>
	/// Cколько пользователей посмотрели 25% видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_25_percents")]
	public long? VideoPlaysUnique25Percents { get; set; }

	/// <summary>
	/// Cколько пользователей посмотрели 50% видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_50_percents")]
	public long? VideoPlaysUnique50Percents { get; set; }

	/// <summary>
	/// Cколько пользователей посмотрели 50% видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_75_percents")]
	public long? VideoPlaysUnique75Percents { get; set; }

	/// <summary>
	/// Cколько пользователей посмотрели 50% видео
	/// </summary>
	[JsonPropertyName("video_plays_unique_100_percents")]
	public long? VideoPlaysUnique100Percents { get; set; }

	/// <summary>
	/// Конверсии
	/// </summary>
	[JsonPropertyName("conversion_count")]
	public long? ConversionCount { get; set; }

	/// <summary>
	/// Ценность конверсий
	/// </summary>
	[JsonPropertyName("conversion_sum")]
	public string ConversionSum { get; set; }

	/// <summary>
	/// Окупаемость затрат на рекламу
	/// </summary>
	[JsonPropertyName("conversion_roas")]
	public string ConversionRoas { get; set; }

	/// <summary>
	/// Коэффициент конверсии
	/// </summary>
	[JsonPropertyName("conversion_cr")]
	public string ConversionCr { get; set; }
}