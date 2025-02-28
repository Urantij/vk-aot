using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Изменение главного фото
/// </summary>
[Serializable]
public class GroupChangePhoto : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя, который внес изменения
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Фотография
	/// </summary>
	[JsonPropertyName("photo")]
	public Photo Photo { get; set; }
}