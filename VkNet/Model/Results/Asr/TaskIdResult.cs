using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Объект TaskId
/// </summary>
[Serializable]
public class TaskIdResult
{
	/// <summary>
	/// Идентификатор созданной задачи на обработку аудиозаписи в формате UUID
	/// </summary>
	[JsonPropertyName("task_id")]
	public string TaskId { get; set; }
}