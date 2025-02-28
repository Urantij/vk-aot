using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Получение скоупов приложения
/// </summary>
[Serializable]
public class AppGetScopes
{
	/// <summary>
	/// Описание.
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; set; }

	/// <summary>
	/// Название.
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; }
}