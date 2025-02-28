using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Результат запроса SaveLookalikeRequestResult
/// </summary>
[Serializable]
public class SaveLookALikeRequestResultResult
{
	/// <summary>
	/// Идентификатор группы ретаргетинга, в которую будет сохранена запрошенная похожая аудитория.
	/// </summary>
	[JsonPropertyName("retargeting_group_id")]
	public long RetargetingGroupId { get; set; }

	/// <summary>
	/// Размер запрошенной похожей аудитории.
	/// </summary>
	[JsonPropertyName("audience_count")]
	public long AudienceCount { get; set; }
}