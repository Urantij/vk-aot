using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// Пол/Возраст
/// </summary>
[Serializable]
public class SexAge
{
	/// <summary>
	/// обозначение возраста
	/// </summary>
	[JsonPropertyName("age_range")]
	public string AgeRange { get; set; }

	/// <summary>
	/// число переходов пользователей женского пола
	/// </summary>
	[JsonPropertyName("female")]
	public ulong Female { get; set; }

	/// <summary>
	/// число переходов пользователей мужского пола
	/// </summary>
	[JsonPropertyName("male")]
	public ulong Male { get; set; }
}