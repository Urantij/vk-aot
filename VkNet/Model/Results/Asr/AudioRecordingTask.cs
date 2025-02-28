using System;
using System.Text.Json.Serialization;
using VkNet.Enums.StringEnums;

namespace VkNet.Model;

/// <summary>
/// Объект задачи на обработку аудиозаписи
/// </summary>
[Serializable]
public class AudioRecordingTask
{
	/// <summary>
	/// Идентификатор созданной задачи на обработку аудиозаписи в формате UUID.
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; set; }

	/// <summary>
	/// Статус задачи на обработку аудиозаписи.
	/// </summary>
	[JsonPropertyName("status")]
	public AsrStatus? Status { get; set; }

	/// <summary>
	/// Расшифровка текста. Имеет значение, если параметр status имеет значение finished.
	/// </summary>
	[JsonPropertyName("text")]
	public string Text { get; set; }
}