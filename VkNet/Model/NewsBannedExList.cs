using System;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Расширеный список забаненых новостей.
/// </summary>
[Serializable]
public class NewsBannedExList
{
	/// <summary>
	/// В поле groups содержится массив идентификаторов сообществ, которые пользователь
	/// скрыл из ленты новостей.
	/// </summary>
	[JsonPropertyName("groups")]
	public ReadOnlyCollection<Group> Groups { get; set; }

	/// <summary>
	/// В поле members содержится массив идентификаторов друзей, которые пользователь
	/// скрыл из ленты новостей.
	/// </summary>
	[JsonPropertyName("profiles")]
	public ReadOnlyCollection<User> Profiles { get; set; }
}