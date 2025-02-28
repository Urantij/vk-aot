using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация об рекламе в аудиозаписи каталога.
/// </summary>
[Serializable]
public class AudioCatalogAudioAds
{
	/// <summary>
	/// Идентификатор контента.
	/// </summary>
	[JsonPropertyName("content_id")]
	public string ContentId { get; set; }

	/// <summary>
	/// Длительность.
	/// </summary>
	[JsonPropertyName("duration")]
	public string Duration { get; set; }

	/// <summary>
	/// Тип возрастной группы пользователей
	/// </summary>
	[JsonPropertyName("account_age_type")]
	public string AccountAgeType { get; set; }

	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("puid1")]
	public int Puid1 { get; set; }

	/// <summary>
	/// Идентификатор
	/// </summary>
	[JsonPropertyName("puid22")]
	public long Puid22 { get; set; }
}