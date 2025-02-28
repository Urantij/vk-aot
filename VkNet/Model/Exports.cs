using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Внешние сервисы, в которые настроен экспорт из ВК
/// </summary>
[Serializable]
public class Exports
{
	/// <summary>
	/// Twitter
	/// </summary>
	[JsonPropertyName("twitter")]
	public bool Twitter { get; set; }

	/// <summary>
	/// Facebook
	/// </summary>
	[JsonPropertyName("facebook")]
	public bool Facebook { get; set; }

	/// <summary>
	/// LiveJournal
	/// </summary>
	[JsonPropertyName("livejournal")]
	public bool Livejournal { get; set; }

	/// <summary>
	/// Instagram
	/// </summary>
	[JsonPropertyName("instagram")]
	public bool Instagram { get; set; }
}