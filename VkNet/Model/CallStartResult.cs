using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат создания нового звонка
/// </summary>
[Serializable]
public class CallStartResult
{
	/// <summary>
	/// Ссылка на звонок
	/// </summary>
	[JsonPropertyName("join_link")]
	public string JoinLink { get; set; }

	/// <summary>
	/// Ссылка на звонок (Ok)
	/// </summary>
	[JsonPropertyName("ok_join_link")]
	public string OkJoinLink { get; set; }

	/// <summary>
	/// Идентификатор созданного звонка
	/// </summary>
	[JsonPropertyName("call_id")]
	public string CallId  { get; set; }
}