using System;
using System.Text.Json.Serialization;
using VkNet.Enums;

namespace VkNet.Model;

/// <summary>
/// Редактирование списка руководителей
/// </summary>
[Serializable]
public class GroupOfficersEdit : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя, чьи полномочия были изменены
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Идентификатор руководителя, который внёс изменения
	/// </summary>
	[JsonPropertyName("admin_id")]
	public long? AdminId { get; set; }

	/// <summary>
	/// Новый уровень полномочий
	/// </summary>
	[JsonPropertyName("level_new")]
	public GroupOfficerLevel? LevelNew { get; set; }

	/// <summary>
	/// Старый уровень полномочий
	/// </summary>
	[JsonPropertyName("level_old")]
	public GroupOfficerLevel? LevelOld { get; set; }
}
