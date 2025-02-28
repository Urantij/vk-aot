using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using VkNet.Utils.JsonConverter;

namespace VkNet.Model;

/// <summary>
/// Предложения новостей.
/// </summary>
[Serializable]
[JsonConverter(typeof(NewsSuggestionJsonConverter))]
public class NewsSuggestions
{
	/// <summary>
	/// Предложения по пользователям.
	/// </summary>
	[JsonPropertyName("profile")]
	public List<User> Users { get; set; }

	/// <summary>
	/// Предложения по группам.
	/// </summary>
	[JsonPropertyName("group")]
	public List<Group> Groups { get; set; }
}