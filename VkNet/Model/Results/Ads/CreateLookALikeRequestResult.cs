using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса LookALikeRequest
/// </summary>
[Serializable]
public class CreateLookALikeRequestResult
{
	/// <summary>
	/// Идентификатор созданного запроса на поиск похожей аудитории
	/// </summary>
	[JsonPropertyName("request_id")]
	public long RequestId { get; set; }
}