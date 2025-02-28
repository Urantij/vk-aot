using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Streaming Settings.
/// </summary>
[Serializable]
public class StreamingSettings
{
	/// <summary>
	/// Месячные ограничения
	/// </summary>
	[JsonPropertyName("monthly_limit")]
	public MonthlyLimit? MonthlyLimit { get; set; }
}