using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Параметры метода groups.setUserNote
/// </summary>
[Serializable]
public class GroupsSetUserNoteParams
{
	/// <summary>
	/// идентификатор сообщества.
	/// положительное число, обязательный параметр
	/// </summary>
	[JsonPropertyName("group_id")]
	public ulong GroupId { get; set; }

	/// <summary>
	/// идентификатор пользователя.
	/// положительное число, обязательный параметр
	/// </summary>
	[JsonPropertyName("user_id")]
	public ulong UserId { get; set; }

	/// <summary>
	/// содержимое заметки, максимальная длина - 96 символов
	/// </summary>
	[JsonPropertyName("note")]
	public string Note { get; set; }
}