using System;
using System.Text.Json.Serialization;

namespace VkNet.Model;

/// <summary>
/// данные о профиле.
/// </summary>
[Serializable]
public class SearchProfile
{
	/// <summary>
	/// идентификатор пользователя
	/// </summary>
	[JsonPropertyName("id")]
	public long Id { get; set; }

	/// <summary>
	/// имя пользователя;
	/// </summary>
	[JsonPropertyName("first_name")]
	public string FirstName { get; set; }

	/// <summary>
	/// фамилия пользователя
	/// </summary>
	[JsonPropertyName("last_name")]
	public string LastName { get; set; }
}