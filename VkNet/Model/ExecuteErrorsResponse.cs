using System;
using System.Collections.ObjectModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ошибоки при вызове метода execute
/// </summary>
[Serializable]
public class ExecuteErrorsResponse
{
	/// <summary>
	/// Ответ Vk
	/// </summary>
	[JsonPropertyName("response")]
	public JsonNode Response { get; set; }

	/// <summary>
	/// Массив ошибок при вызове метода execute
	/// </summary>
	[JsonPropertyName("execute_errors")]
	public ReadOnlyCollection<VkError> ExecuteErrors { get; set; }
}