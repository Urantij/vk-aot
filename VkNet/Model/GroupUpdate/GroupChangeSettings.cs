using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Событие о изменении настроек сообщества
/// </summary>
[Serializable]
public class GroupChangeSettings : IGroupUpdate
{
	/// <summary>
	/// Идентификатор пользователя, который внёс изменения;
	/// </summary>
	[JsonPropertyName("user_id")]
	public long? UserId { get; set; }

	/// <summary>
	/// Описание внесённых изменений
	/// </summary>
	[JsonPropertyName("changes")]
	public Dictionary<string, Change> Changes { get; set; }
}