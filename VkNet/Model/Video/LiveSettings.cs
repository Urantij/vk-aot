using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры прямой трансляции
/// </summary>
[Serializable]
public class LiveSettings
{
	/// <summary>
	/// Можно ли перематывать прямую трансляцию
	/// </summary>
	[JsonPropertyName("can_rewind")]
	public int? CanRewind { get; set; }

	/// <summary>
	/// Является ли прямая трансляция бесконечной
	/// </summary>
	[JsonPropertyName("is_endless")]
	public int? IsEndless { get; set; }

	/// <summary>
	/// Максимальная длительность прямой трансляции в секундах
	/// </summary>
	[JsonPropertyName("max_duration")]
	public int? MaxDuration { get; set; }
}