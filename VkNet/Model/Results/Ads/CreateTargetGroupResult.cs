using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат метода Ads.CreateTargetGroup
/// </summary>
[Serializable]
public class CreateTargetGroupResult
{
	/// <summary>
	/// Идентификатор аудитории.
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }
}