using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода ShareTargetGroup
/// </summary>
[Serializable]
public class ShareTargetGroupResult
{
	/// <summary>
	/// Идентификатор аудитории.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }
}