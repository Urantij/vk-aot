using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат выполнения метода RemoveTargetContactsResult
/// </summary>
[Serializable]
public class RemoveTargetContactsResult
{
	/// <summary>
	/// Результат.
	/// </summary>
	[JsonPropertyName("result")]
	public bool Result { get; set; }
}