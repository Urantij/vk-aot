using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Список забаненых новостей.
/// </summary>
[Serializable]
public class NewsBannedList
{
	/// <summary>
	/// В поле groups содержится массив идентификаторов сообществ, которые пользователь
	/// скрыл из ленты новостей.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<ulong> Groups { get; set; }

	/// <summary>
	/// В поле members содержится массив идентификаторов друзей, которые пользователь
	/// скрыл из ленты новостей.
	/// </summary>
	[JsonPropertyName("members")]
	public ReadOnlyCollection<ulong> Members { get; set; }
}