using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Информация о репостах записи.
/// См. описание http://vk.com/dev/post
/// </summary>
[Serializable]
public class Reposts
{
	/// <summary>
	/// Число пользователей, скопировавших запись.
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; }

	/// <summary>
	/// Наличие репоста от текущего пользователя .
	/// </summary>
	[JsonPropertyName("user_reposted")]
	public bool UserReposted { get; set; }
}