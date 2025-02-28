using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Обложка сообщества.
/// </summary>
[Serializable]
public class GroupCover
{
	/// <summary>
	/// Информация о том, включена ли обложка (1 — да, 0 — нет);
	/// </summary>
	[JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Копии изображений обложки.
	/// </summary>
	[JsonPropertyName("images")]
	public IEnumerable<GroupCoverImage> Images { get; set; }
}