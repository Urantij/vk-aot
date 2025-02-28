using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Ответ на методы stories
/// </summary>
[Serializable]
public class StoryResult<T>
{
	/// <summary>
	/// Число подборок
	/// </summary>
	[JsonPropertyName("count")]
	public long Count { get; set; }

	/// <summary>
	/// Массив данных
	/// </summary>
	[JsonPropertyName("items")]
	public IEnumerable<T> Items { get; set; }

	/// <summary>
	/// Профили пользователей
	/// </summary>
	[JsonPropertyName("profiles")]
	public IEnumerable<User> Profiles { get; set; }

	/// <summary>
	/// Сообщества
	/// </summary>
	[JsonPropertyName("groups")]
	public IEnumerable<Group> Groups { get; set; }
}