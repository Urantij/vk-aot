using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Список доступных размеров аудитории для сохранения.
/// </summary>
[Serializable]
public class SaveAudienceLevels
{
	/// <summary>
	/// Параметра level в ads.saveLookalikeRequestResult
	/// </summary>
	[JsonPropertyName("level")]
	public long? Level { get; set; }

	/// <summary>
	/// Размер похожей аудитории в данной опции.
	/// </summary>
	[JsonPropertyName("audience_count")]
	public long? AudienceCount { get; set; }
}