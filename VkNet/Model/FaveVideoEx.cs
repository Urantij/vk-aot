using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Расширенный объект видео для закладок
/// </summary>
[Serializable]
public class FaveVideoEx
{
	/// <summary>
	/// Общее количество записей на стене.
	/// </summary>
	[JsonPropertyName("count")]
	public ulong Count { get; set; }

	/// <summary>
	/// Видеозаписи.
	/// </summary>
	[JsonPropertyName("items")]
	public ReadOnlyCollection<Video> Videos { get; set; }

	/// <summary>
	/// Профили.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }

	/// <summary>
	/// Группы.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }
}