using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Расширенная информация о пользователях или сообществах.
/// </summary>
[Serializable]
[JsonConverter(typeof(UserOrGroupJsonConverter))]
public class UserOrGroup
{
	/// <summary>
	/// Общее количество элементов.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong TotalCount { get; set; }

	/// <summary>
	/// Список пользователей.
	/// </summary>
	[JsonPropertyName("profile")]
	public List<User> Users { get; set; }

	/// <summary>
	/// Список групп.
	/// </summary>
	[JsonPropertyName("group")]
	public List<Group> Groups { get; set; }
}